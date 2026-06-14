using szyfr;

namespace Testy
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void DanePodstawowe()
        {
            Szyfrowanie szyfr = new Szyfrowanie();
            string tekstJawny = "abc";
            int klucz = 3;
            string oczekiwane = "def";
            string aktualne = szyfr.zaszyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwane, aktualne);
        }

        [TestMethod]
        public void Zawijanie()
        {
            Szyfrowanie szyfr = new Szyfrowanie();
            string tekstJawny = "xyz";
            int klucz = 3;
            string oczekiwane = "abc";
            string aktualne = szyfr.zaszyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwane, aktualne);
        }

        [TestMethod]
        public void Odszyfrowanie()
        {
            Szyfrowanie szyfr = new Szyfrowanie();
            string tekstJawny = "def";
            int klucz = -3;
            string oczekiwane = "abc";
            string aktualne = szyfr.zaszyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwane, aktualne);
        }

        [TestMethod]
        public void KluczWiekszyNizDlugoscAlfabetu()
        {
            Szyfrowanie szyfr = new Szyfrowanie();
            string tekstJawny = "abc";
            int klucz = 29;
            string oczekiwane = "def";
            string aktualne = szyfr.zaszyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwane, aktualne);
        }

        [TestMethod]
        public void SpacjaWTekscie()
        {
            Szyfrowanie szyfr = new Szyfrowanie();
            string tekstJawny = "ab cd";
            int klucz = 2;
            string oczekiwane = "cd ef";
            string aktualne = szyfr.zaszyfruj(tekstJawny, klucz);
            Assert.AreEqual(oczekiwane, aktualne);
        }

    }
}
