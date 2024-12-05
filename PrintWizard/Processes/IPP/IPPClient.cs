using SharpIpp;
using SharpIpp.Exceptions;
using SharpIpp.Models;
using SharpIpp.Protocol.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
namespace PrintWizard.Processes.IPP
{
    public class IPPClient : IDisposable
    {
        private readonly SharpIppClient _ippClient;
        private readonly Uri _printerUri;
        private readonly string _requestingUserName;

        public SharpIppClient SharpIppClient => _ippClient;

        public IPPClient(string printerUri, string requestingUserName)
        {
            _printerUri = new Uri(printerUri);
            _ippClient = new SharpIppClient();
            _requestingUserName = requestingUserName;
        }

        public IPPClient(Uri printerUri, string requestingUserName)
        {
            _printerUri = printerUri;
            _ippClient = new SharpIppClient();
            _requestingUserName = requestingUserName;
        }

        public async Task<GetPrinterAttributesResponse> GetPrinterAttributesAsync(CancellationToken cancellationToken = default)
        {
            var request = new GetPrinterAttributesRequest
            {
                PrinterUri = _printerUri,
                Version = IppVersion.V11,
                RequestedAttributes = null
            };
            try
            {
                return await _ippClient.GetPrinterAttributesAsync(request, cancellationToken);
            }
            catch (IppResponseException ex)
            {
                Console.WriteLine($"Error parsing IPP response: {ex.Message}");
                // Handle the exception or rethrow it if necessary
                throw;
            }
        }

        public async Task<PrintJobResponse> PrintDocumentAsync(string documentPath, CancellationToken cancellationToken = default)
        {
            using var stream = File.OpenRead(documentPath);
            var request = new PrintJobRequest
            {
                PrinterUri = _printerUri,
                Document = stream,
                NewJobAttributes = new NewJobAttributes
                {
                    JobName = "Print Job",
                    Copies = 1,
                    Sides = Sides.OneSided,
                    OrientationRequested = Orientation.Portrait,
                    PrintQuality = PrintQuality.Normal,
                    AdditionalJobAttributes = new List<IppAttribute>
                    {
                        //new(Tag.NameWithLanguage, "requesting-user-name", "Vladislav Gaydukevich"),
                        //new(Tag.NameWithLanguage, "job-originating-user-name", "Vladislav Gaydukevich"),
                        //new(Tag.OctetStringUnassigned38, "job-password", "1234")
                    },
                },
                DocumentAttributes = new DocumentAttributes
                {
                    DocumentName = Path.GetFileName(documentPath),
                    DocumentFormat = "application/octet-stream",
                    DocumentNaturalLanguage = "en-us"
                }
            };

            return await _ippClient.PrintJobAsync(request, cancellationToken);
        }

        public async Task<PrintJobResponse> PrintSecureDocumentAsync(string documentPath, string pinCode, CancellationToken cancellationToken = default)
        {
            using var stream = File.OpenRead(documentPath);
            var request = new PrintJobRequest
            {
                PrinterUri = _printerUri,
                Document = stream,
                RequestingUserName = _requestingUserName,
                NewJobAttributes = new NewJobAttributes
                {
                    JobName = "Secure Print Job",
                    Copies = 1,
                    Sides = Sides.OneSided,
                    OrientationRequested = Orientation.Portrait,
                    PrintQuality = PrintQuality.Normal,
                    JobHoldUntil = JobHoldUntil.Indefinite,
                    AdditionalJobAttributes = new[]
                    {
                        new IppAttribute(Tag.NameWithoutLanguage, "job-hold-until-name", pinCode)
                    }
                },
                DocumentAttributes = new DocumentAttributes
                {
                    DocumentName = Path.GetFileName(documentPath),
                    DocumentFormat = "application/octet-stream",
                    DocumentNaturalLanguage = "en"
                }
            };

            return await _ippClient.PrintJobAsync(request, cancellationToken);
        }

        public async Task<GetJobAttributesResponse> GetJobAttributesAsync(int jobId, CancellationToken cancellationToken = default)
        {
            var request = new GetJobAttributesRequest
            {
                PrinterUri = _printerUri,
                JobId = jobId,
                RequestingUserName = _requestingUserName
            };
            return await _ippClient.GetJobAttributesAsync(request, cancellationToken);
        }

        public async Task<CancelJobResponse> CancelJobAsync(int jobId, CancellationToken cancellationToken = default)
        {
            var request = new CancelJobRequest
            {
                PrinterUri = _printerUri,
                JobId = jobId,
                RequestingUserName = _requestingUserName
            };
            return await _ippClient.CancelJobAsync(request, cancellationToken);
        }

        public void Dispose()
        {
            _ippClient.Dispose();
        }
    }
}
