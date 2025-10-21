namespace ConsoleApp
{
    public class ElektronickiUredaj
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }

        public ElektronickiUredaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }
        public void IspisiInformacije()
        {
            Console.WriteLine($"Uređaj: {Naziv}, Proizvođač: {Proizvodjac}, Godina Proizvodnje: {GodinaProizvodnje}");
        }
    }

}
