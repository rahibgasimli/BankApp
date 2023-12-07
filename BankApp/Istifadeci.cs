namespace BankApp
{
    public class Istifadeci
    {
        public string Ad;
        public string Soyad;
        public string MobilNomre;
        private double _hesab;


        public void PulElaveEt(double elaveEdilecek)
        {
            if(elaveEdilecek <= 0)
            {
                Console.WriteLine("Deyer menfi ola bilmez");
            }
            else
            {
                _hesab = _hesab + elaveEdilecek;
                // _hesab += elaveedilecek
            }
        }

        public void PulCixart(int cixarilacaqPul)
        {
            if(cixarilacaqPul <= 0)
            {
                Console.WriteLine("Deyer menfi ola bilmez");
            }
            else if(cixarilacaqPul > _hesab)
            {
                Console.WriteLine("Balansda vesait yoxdur");
            }
            else
            {
                _hesab -= cixarilacaqPul;
            }
        }


    }
}
