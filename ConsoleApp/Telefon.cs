namespace ConsoleApp
{ 
    public class PametniTelefon : ElektronickiUredaj
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
