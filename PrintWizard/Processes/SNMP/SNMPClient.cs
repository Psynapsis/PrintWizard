using CSharpFunctionalExtensions;
using SnmpSharpNet;
using System;
using System.Net;

namespace PrintWizard.Processes.SNMP
{
    public class SNMPClient
    {
        private readonly string _host;
        private readonly string _community;
        private readonly int _port;
        private readonly int _timeout;
        private readonly int _retries;

        /// <summary>
        /// SNMPClient class constructor
        /// </summary>
        /// <param name=“host”>IP address or equipment host</param>
        /// <param name=“community”>SNMP community string</param>
        /// <param name=“port”>SNMP port (default 161)</param>
        /// <param name=“timeout”>Query timeout (in milliseconds)</param>
        /// <param name=“retries”>Number of retry attempts</param>
        /// <param name="version">SNMP protocol version, do not use version 3</param>
        public SNMPClient(string host, string community, int port = 161, int timeout = 2000, int retries = 2, SnmpVersion version = SnmpVersion.Ver2)
        {
            _host = host;
            _community = community;
            _port = port;
            _timeout = timeout;
            _retries = retries;
        }


        /// <summary>
        /// Querying the OID value using SNMP GET
        /// </summary>
        /// <param name=“oid”>OID to retrieve value</param>
        /// <returns>Result as a string or null in case of error</returns>
        public Result<string> Get(string oid)
        {
            try
            {
                UdpTarget target = new UdpTarget(new IPAddress(IPAddress.Parse(_host).GetAddressBytes()), _port, _timeout, _retries);

                Pdu pdu = new Pdu(PduType.Get);
                pdu.VbList.Add(oid);

                AgentParameters parameters = new AgentParameters(SnmpVersion.Ver2, new OctetString(_community));

                SnmpV2Packet response = target.Request(pdu, parameters) as SnmpV2Packet;

                if (response != null && response.Pdu.ErrorStatus == 0)
                {
                    return response.Pdu.VbList[0].Value.ToString();
                }
                else
                {
                    return Result.Failure<string>($"SNMP Error: ErrorStatus: {response?.Pdu.ErrorStatus}, ErrorIndex: {response?.Pdu.ErrorIndex})");
                }
            }
            catch (Exception ex)
            {
                return Result.Failure<string>($"Exception in SNMP Get: {ex.Message}");
            }
        }

        /// <summary>
        /// Setting the OID value using SNMP SET
        /// </summary>
        /// <param name=“oid”>OID to set value</param>
        /// <param name=“value”>Value to set</param>
        /// <returns>True if the request is successful, otherwise False</returns>
        public UnitResult<string> Set(string oid, string value)
        {
            try
            {
                UdpTarget target = new UdpTarget(new IPAddress(IPAddress.Parse(_host).GetAddressBytes()), _port, _timeout, _retries);

                Pdu pdu = new Pdu(PduType.Set);
                pdu.VbList.Add(new Vb(new Oid(oid), new OctetString(value)));

                AgentParameters parameters = new AgentParameters(SnmpVersion.Ver2, new OctetString(_community));

                SnmpV2Packet response = target.Request(pdu, parameters) as SnmpV2Packet;

                if (response != null && response.Pdu.ErrorStatus == 0)
                {
                    return Result.Success();
                }
                else
                {
                    return Result.Failure($"SNMP Error: ErrorStatus: {response?.Pdu.ErrorStatus}, ErrorIndex: {response?.Pdu.ErrorIndex})");
                }
            }
            catch (Exception ex)
            {
                return Result.Failure($"Exception in SNMP Set: {ex.Message}");
            }
        }
    }
}
