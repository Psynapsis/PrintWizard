using SharpIpp;
using SharpIpp.Exceptions;
using SharpIpp.Models;
using SharpIpp.Protocol.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PrintWizard.Processes.IPP
{
    public class IPPClient : IDisposable
    {
        private readonly SharpIppClient _ippClient;
        private readonly Uri _printerUri;
        private readonly string _requestingUserName;
        private readonly string _password;

        public SharpIppClient SharpIppClient => _ippClient;

        public IPPClient(string printerUri)
        {
            _printerUri = new Uri(printerUri);

            var handler = new HttpClientHandler
            {
                SslProtocols = System.Security.Authentication.SslProtocols.Tls13, 
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true, // Принудительное принятие всех сертификатов (небезопасно для продакшн-среды)
            };

            var httpClient = new HttpClient(handler);
            httpClient.BaseAddress = _printerUri;
            _ippClient = new SharpIppClient(httpClient);
        }

        public IPPClient(Uri printerUri)
        {
            _printerUri = printerUri;

            var handler = new HttpClientHandler
            {
                SslProtocols = System.Security.Authentication.SslProtocols.Tls13, 
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true,
            };

            var httpClient = new HttpClient(handler);
            httpClient.BaseAddress = _printerUri;
            _ippClient = new SharpIppClient(httpClient);
        }

        public async Task<GetPrinterAttributesResponse> GetPrinterAttributesAsync(CancellationToken cancellationToken = default)
        {
            var request = new GetPrinterAttributesRequest
            {
                PrinterUri = _printerUri,
            };
            return await _ippClient.GetPrinterAttributesAsync(request, cancellationToken);
        }

        public async Task<PrintJobResponse> PrintDocumentAsync(string documentPath, string userName, CancellationToken cancellationToken = default)
        {
            var stream = File.OpenRead(documentPath);
            var request = new PrintJobRequest
            {
                PrinterUri = _printerUri,
                Document = stream,
                NewJobAttributes = new NewJobAttributes
                {
                    JobName = $"Print Job by {Path.GetFileName(documentPath)}",
                    Copies = 1,
                    Sides = Sides.OneSided,
                    PrintQuality = PrintQuality.Normal,
                    AdditionalOperationAttributes = new List<IppAttribute>
                    {
                        new(Tag.NameWithoutLanguage, "requesting-user-name", userName),
                        new(Tag.Keyword, "job-password-encryption", "none"),
                    }
                },
                DocumentAttributes = new DocumentAttributes
                {
                    DocumentName = Path.GetFileName(documentPath),
                    DocumentFormat = "application/octet-stream",
                    DocumentNaturalLanguage = "en"
                }
            };

            var result = await _ippClient.PrintJobAsync(request, cancellationToken);
            stream.Dispose();
            return result;
        }

        public async Task<PrintJobResponse> PrintSecureDocumentAsync(string documentPath, string userName, string pinCode, CancellationToken cancellationToken = default)
        {
            var stream = File.OpenRead(documentPath);
            var request = new PrintJobRequest
            {
                PrinterUri = _printerUri,
                Document = stream,
                RequestingUserName = _requestingUserName,
                NewJobAttributes = new NewJobAttributes
                {
                    JobName = $"Secure Print {Path.GetFileName(documentPath)}",
                    Sides = Sides.OneSided,
                    PrintQuality = PrintQuality.Normal,
                    JobHoldUntil = JobHoldUntil.Indefinite,
                    AdditionalOperationAttributes = new List<IppAttribute>
                    {
                        new(Tag.NameWithoutLanguage, "requesting-user-name", userName),
                        new(Tag.Keyword, "job-password-encryption", "none"),
                        new(Tag.OctetStringWithAnUnspecifiedFormat, "job-password", pinCode)
                    }
                },
                DocumentAttributes = new DocumentAttributes
                {
                    DocumentName = Path.GetFileName(documentPath),
                    DocumentFormat = "application/octet-stream",
                    DocumentNaturalLanguage = "en"
                }
            };

            var result = await _ippClient.PrintJobAsync(request, cancellationToken);
            stream.Dispose();
            return result;
        }

        public async Task<GetJobAttributesResponse> GetJobAttributesAsync(int jobId, CancellationToken cancellationToken = default)
        {
            var request = new GetJobAttributesRequest
            {
                PrinterUri = _printerUri,
                JobId = jobId
            };
            return await _ippClient.GetJobAttributesAsync(request, cancellationToken);
        }

        public async Task<CancelJobResponse> CancelJobAsync(int jobId, CancellationToken cancellationToken = default)
        {
            var request = new CancelJobRequest
            {
                PrinterUri = _printerUri,
                JobId = jobId
            };
            return await _ippClient.CancelJobAsync(request, cancellationToken);
        }


        public async Task<GetJobsResponse> GetAllJobsAsync(CancellationToken cancellationToken = default)
        {
            var request = new GetJobsRequest
            {

            };
            return await _ippClient.GetJobsAsync(request, cancellationToken);
        }

        public void Dispose()
        {
            _ippClient.Dispose();
        }
    }
}
