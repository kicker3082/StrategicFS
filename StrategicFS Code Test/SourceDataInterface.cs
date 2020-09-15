using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace StrategicFS_Code_Test
{
    public class CreditAccountInfo
    {
        public int Id { get; set; }
        public string CreditorName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal MinPaymentPercentage { get; set; }
        public decimal Balance { get; set; }
    }

    /// <summary>
    /// Handles interactions with the source json data
    /// </summary>
    public class SourceDataInterface
    {
        private readonly string _url;
        private readonly string _fileName;

        public SourceDataInterface(string url, string fileName)
        {
            _url = url;
            _fileName = fileName;
        }
        public IEnumerable<CreditAccountInfo> DownloadDataFromUrl()
        {
            var wc = new WebClient();
            var content = wc.DownloadString(_url);

            return JsonConvert.DeserializeObject<List<CreditAccountInfo>>(content);
        }

        public void CacheDataToLocalFile(IEnumerable<CreditAccountInfo> creditAccountItems)
        {
            var json = JsonConvert.SerializeObject(creditAccountItems);
            File.WriteAllText(_fileName, json);
        }

        public IEnumerable<CreditAccountInfo> LoadCreditAccountInfo()
        {
            var text = File.ReadAllText(_fileName);
            var items = JsonConvert.DeserializeObject<List<CreditAccountInfo>>(text);
            return items;
        }
    }
}
