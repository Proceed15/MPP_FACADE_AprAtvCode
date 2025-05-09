/// Facade (üst) Sınıf

    public class Kredi
    {
        HesapBilgisi hesapbilgisi = new HesapBilgisi();
        KredilerininDurumu kredileri = new KredilerininDurumu();
        KrediSkoru krediskoru = new KrediSkoru();

        public bool UygunMu(Musteri musteri, int miktar)
        {
            Console.WriteLine("{0}, {1}e kadar kredi için başvuruda bulundu. Kotroller gerçekleştirilip, başvuru sonuçlandırılacak:\n",
                musteri.Name, miktar);

            bool uygun = true;

            // Kredi Kontrollerini gerçekleştirip buna bağlı olarak kredi alıp alamayacağına karar ver:

            if (!hesapbilgisi.YeterliBirikimVarMi(musteri, miktar))
            {
                uygun = false;
            }
            else if (!kredileri.KredilerininDurumuIyiMi(musteri))
            {
                uygun = false;
            }
            else if (!krediskoru.KrediSkoruIyiMi(musteri))
            {
                uygun = false;
            }

            return uygun;
        }
    }
