using NUnit.Framework;
using StrategicFS_Code_Test;
using System.Linq;

namespace StrategicFS_Code_Test_Fixture
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FileIngester_LoadDataFromUrl_LoadsItems()
        {
            var ing = new SourceDataInterface(
                "https://raw.githubusercontent.com/StrategicFS/Recruitment/master/data.json",
                "data.json");
            var items = ing.DownloadDataFromUrl()
                .ToArray();

            Assert.That(items, Is.Not.Null);
            Assert.That(items.Length, Is.EqualTo(10));
            Assert.That(items[0].Id, Is.EqualTo(1));
            Assert.That(items[9].Id, Is.EqualTo(10));
        }
    }
}