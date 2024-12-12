using Avalonia;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using DynamicData;
using Microsoft.Extensions.Configuration;
using PrintWizard.Processes.IPP;
using ReactiveUI;
using SharpIpp.Exceptions;
using SharpIpp.Models;
using SharpIpp.Protocol.Models;
using Splat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;

namespace PrintWizard.ViewModels
{
    public class IPPViewModel : ViewModelBase
    {
        private IConfiguration _configuration;
        private TopLevel _topLevel;
        private string _filePath;
        private string _pinCode;
        private IPPClient _client;
        private bool _securePrint;
        private PrintJobResponse _responsePrint;
        private string _messagePrinter;
        private string _userName;

        public string UserName
        {
            get => _userName;
            set => this.RaiseAndSetIfChanged(ref _userName, value);
        }

        public string MessagePrinter
        {
            get => _messagePrinter;
            set => this.RaiseAndSetIfChanged(ref _messagePrinter, value);
        }

        public PrintJobResponse ResponsePrint
        {
            get => _responsePrint;
            set => this.RaiseAndSetIfChanged(ref _responsePrint, value);
        }

        public bool SecurePrint
        {
            get => _securePrint;
            set => this.RaiseAndSetIfChanged(ref _securePrint, value);
        }

        public string FilePath
        {
            get => _filePath;
            set => this.RaiseAndSetIfChanged(ref _filePath, value);
        }

        public string PinCode
        {
            get => _pinCode;
            set => this.RaiseAndSetIfChanged(ref _pinCode, value);
        }


        private ObservableCollection<IppSection> _sections = new ObservableCollection<IppSection>();
        public ObservableCollection<IppSection> Sections
        {
            get => _sections;
            set => this.RaiseAndSetIfChanged(ref _sections, value);
        } 
        public ObservableCollection<int> ObservableJobsId { get; set; } = new ObservableCollection<int>();
        public ReactiveCommand<Unit, Unit> PrintCommand { get; }
        public ReactiveCommand<Unit, Unit> GetAttributeCommand { get; }
        public ReactiveCommand<Unit, Unit> SelectedFileCommand { get; }

        public IPPViewModel(IConfiguration configuration, TopLevel topLevel)
        {
            PrintCommand = ReactiveCommand.Create(Print);
            GetAttributeCommand = ReactiveCommand.Create(GetAttribute);
            SelectedFileCommand = ReactiveCommand.Create(SelectedFile);
            _configuration = configuration;
            _topLevel = topLevel;

            var host = _configuration.GetSection("IPPSetting:HostAddres").Value;
            var port = Convert.ToInt32(_configuration.GetSection("IPPSetting:PortAddres").Value);

            _client = new($"ipps://{host}:{443}/ipp/print");
        }

        private async void SelectedFile()
        {
            var files = await _topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
            {
                Title = "Open",
                AllowMultiple = false,
                FileTypeFilter = new List<FilePickerFileType>
                {
                    new FilePickerFileType("PDF Files") { Patterns = new List<string> { "*.pdf" } },
                    new FilePickerFileType("JPEG Files") { Patterns = new List<string> { "*.jpg" } },
                    new FilePickerFileType("Text Files") { Patterns = new List<string> { "*.txt" } }
                }
            });
            if (files.Count > 0) 
            {
                FilePath = files.FirstOrDefault().Path.AbsolutePath;
            }
        }

        private async void Print()
        {
            try
            {
                PrintJobResponse response;
                if (SecurePrint)
                    response = await _client.PrintSecureDocumentAsync(FilePath, UserName, PinCode);
                else
                    response = await _client.PrintDocumentAsync(FilePath, UserName);

                ObservableJobsId.Add(response.JobId);

                ResponsePrint = response;
            }
            catch (Exception ex)
            { 
                MessagePrinter = ex.Message;
            }
        }

        private async void GetAttribute()
        {
            try
            {
                var response = await _client.GetPrinterAttributesAsync();

                Sections = new ObservableCollection<IppSection>(response.Sections);
            }
            catch (IppResponseException ex)
            {
                //For some reason, depending on the position of Mars in the sky,
                //it gives an error that it cannot parse one certain string with an error:
                //“0 length attribute name found not in a 1setOf”.

                Sections = new ObservableCollection<IppSection>(ex.ResponseMessage.Sections);
                MessagePrinter = "Error parsing response";
            }
            catch (Exception ex)
            {
                MessagePrinter = ex.Message;

            }
        }
    }
}
