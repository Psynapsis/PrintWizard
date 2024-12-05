using Microsoft.Extensions.Configuration;
using PrintWizard.Processes.IPP;
using ReactiveUI;
using System;
using System.Reactive;

namespace PrintWizard.ViewModels
{
    public class IPPViewModel : ViewModelBase
    {
        private IConfiguration _configuration;
        private string _filePath;
        private string _pinCode;
        private IPPClient _client;


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

        public ReactiveCommand<Unit, Unit> PrintCommand { get; }
        public ReactiveCommand<Unit, Unit> GetAttributeCommand { get; }

        public IPPViewModel(IConfiguration configuration)
        {
            PrintCommand = ReactiveCommand.Create(Print);
            GetAttributeCommand = ReactiveCommand.Create(GetAttribute);
            _configuration = configuration;

            var host = _configuration.GetSection("IPPSetting:HostAddres").Value;
            var port = Convert.ToInt32(_configuration.GetSection("IPPSetting:PortAddres").Value);

            _client = new(new Uri($"ipp://{host}:{port}"), "LEXMARK_SOSATI");
        }

        private async void Print()
        {
            try
            {
                var documentPath = "C:\\Users\\vladi\\OneDrive\\Рабочий стол\\pdf-test.pdf";
                var result = await _client.PrintDocumentAsync(documentPath);

            }
            catch
            { }
        }

        private async void GetAttribute()
        {
            try
            {
                var response = await _client.GetPrinterAttributesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при запросе атрибутов принтера: {ex.Message}");
            }
        }
    }
}
