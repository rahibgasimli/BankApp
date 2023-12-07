using System.Xml.Serialization;

namespace BankApp
{
    public class Bank
    {

        public Bank()
        {
            if (File.Exists(faylAdi))
            {
                _istifadeciler = IstifadecileriOxu();
                _istifadeciler.Add(yeniMusteri);
                IstifadecileriYaddaSaxla();
            }
            else
            {
                _istifadeciler = new();
            }


        }

        public string Ad;

        public string Nomre;

        public string Mail;

        public string Parol;

        private List<Istifadeci> _istifadeciler = new();
        private string faylAdi = "istifadeciler.xml";

        public void IstifadeciElaveEt(Istifadeci yeniMusteri)
        {
            _istifadeciler.Add(yeniMusteri);
            IstifadecileriYaddaSaxla();
        }

        private void IstifadecileriYaddaSaxla()
        {
            var fayl = File.Open(faylAdi, FileMode.Create);
            XmlSerializer xml = new(typeof(List<Istifadeci>));
            xml.Serialize(fayl, _istifadeciler);
            fayl.Close();
        }

        private List<Istifadeci> IstifadecileriOxu()
        {
            var f = File.OpenRead(faylAdi);
            XmlSerializer xml = new(typeof(List<Istifadeci>));
            var istifadeciler = (List<Istifadeci>?)xml.Deserialize(f);
            f.Close();


            if (istifadeciler == null)
            {
                return new List<Istifadeci>();
            }
            else
            {
                return istifadeciler;
            }


        }
    }
}
