﻿using Avalonia.Controls;
using DynamicData.Binding;
using FluentAvalonia.UI.Controls;
using PrintWizard.Model;
using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace PrintWizard.ViewModels
{
    public class MainWindowsViewModel : ViewModelBase
    {
        public ObservableCollection<NavigatePanelItemBase> PanelItems { get; set; } = new ObservableCollection<NavigatePanelItemBase>();

        private NavigatePanelItemBase _selectedContent;
        public NavigatePanelItemBase SelectedContent
        {
            get => _selectedContent;
            set
            {
                this.RaiseAndSetIfChanged(ref _selectedContent, value);
                CurrentPage = SelectedContent.ViewUserControl;
            }
        }

        private Control _currentPage;
        public Control CurrentPage
        {
            get => _currentPage;
            set => this.RaiseAndSetIfChanged(ref _currentPage, value);
        }

        public ICommand SelectionChangeCommand;

        public MainWindowsViewModel()
        {
            PanelItems.Add(new NavigatePanelItemBase { Name = "SNMP", Icon = Symbol.Play, Tag = "SNMP", ToolTip = "Polling the printer via SNMP flow", ViewUserControl = new SNMPView() });
            PanelItems.Add(new NavigatePanelItemBase { Name = "IPP", Icon = Symbol.Print, Tag = "IPP", ToolTip = "Printing and polling via IPP protocol", ViewUserControl = new IPPView() });
            this.RaisePropertyChanged(nameof(PanelItems));

            CurrentPage = PanelItems.FirstOrDefault().ViewUserControl;
        }
    }
}