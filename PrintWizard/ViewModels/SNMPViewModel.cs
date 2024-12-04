using Microsoft.Extensions.Configuration;
using PrintWizard.Processes.SNMP;
using ReactiveUI;
using System;
using System.Reactive;
using System.Windows.Input;

namespace PrintWizard.ViewModels
{
    public class SNMPViewModel : ViewModelBase
    {
        private string _oidRequest;
        private string _oidResponse;
        private IConfiguration _configuration { get; }
        private SNMPClient SNMPClient;

        public string OIDRequest
        {
            get => _oidRequest;
            set => this.RaiseAndSetIfChanged(ref _oidRequest, value);
        }

        public string OIDResponse
        {
            get => _oidResponse;
            set => this.RaiseAndSetIfChanged(ref _oidResponse, value);
        }

        public ReactiveCommand<Unit, Unit> GetOidDataCommand { get; }

        public SNMPViewModel(IConfiguration configuration)
        {
            GetOidDataCommand = ReactiveCommand.Create(GetOidData);
            _configuration = configuration;
        }
         
        private void GetOidData()
        {
            if (SNMPClient is null)
                if(!CreateSNMPClient())
                    return;
            try
            {
                OIDResponse = string.Empty;

                var result = SNMPClient.Get(SnmpSharpNet.SnmpVersion.Ver2, _oidRequest);

                if(result is not null)
                {
                    foreach(var item in result)
                    {
                        OIDResponse = OIDResponse + $"{item.Key} : {item.Value}. {Environment.NewLine}";
                    }
                }
            }
            catch (Exception ex)
            {
                OIDResponse = ex.Message;
            }
        }

        private bool CreateSNMPClient()
        {
            try { 

                var host = _configuration.GetSection("SNMPSetting:HostAddres").Value;
                var port = Convert.ToInt32(_configuration.GetSection("SNMPSetting:PortAddres").Value);

                SNMPClient = new SNMPClient(host, port);

                return true;
            }
            catch { 
                return false;
            }
;        }
    }
}
