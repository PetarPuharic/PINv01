namespace ConsoleApp
{
    public class ElektronickiUredjaj
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public int GodinaProizvodnje { get; set; }

        public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }
    }
    public class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodjac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav;
        }
        public void InstalirajAplikaciju(string nazivAplikacije)
        {
            Console.WriteLine($"Instalirana aplikacija: {nazivAplikacije} na {Naziv}");
        }

    }
}
