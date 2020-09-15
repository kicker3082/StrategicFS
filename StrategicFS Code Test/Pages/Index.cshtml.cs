using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace StrategicFS_Code_Test.Pages
{
    public class CreditAccountItemViewModel
    {
        public bool IsSelected { get; set; }
        public string Id { get; set; }
        public string CreditorName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MinPaymentPercentage { get; set; }
        public string Balance { get; set; }
    }
    public class IndexModel : PageModel
    {
        public List<CreditAccountItemViewModel> CreditAccountInfo { get; set; }

        public IndexModel()
        {
            CreditAccountInfo = new List<CreditAccountItemViewModel>();
        }

        public void OnGet()
        {
            var ing = new SourceDataInterface(
                "https://raw.githubusercontent.com/StrategicFS/Recruitment/master/data.json",
                "data.json");
            var items = ing.DownloadDataFromUrl().Select(item => new CreditAccountItemViewModel
            {
                IsSelected = true,
                Id = item.Id.ToString(),
                CreditorName = item.CreditorName,
                FirstName = item.FirstName,
                LastName = item.LastName,
                MinPaymentPercentage = item.MinPaymentPercentage.ToString("#0.00%"),
                Balance = item.Balance.ToString("#0.00")
            });
            CreditAccountInfo.Clear();
            CreditAccountInfo.AddRange(items);
        }

        public void OnGetAddItem()
        {
            CreditAccountInfo.Add(new CreditAccountItemViewModel {
                Id = "new",
                IsSelected = false,
                CreditorName = "",
                FirstName = "",
                LastName = "",
                MinPaymentPercentage = "",
                Balance = ""
            });
        }
    }
}
