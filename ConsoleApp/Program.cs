namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proizvod proizvod = new Proizvod("Laptop", 1500.00m, 10);
            Proizvod drugiProizvod = new Proizvod("Pametni telefon", 800.00m, 25);
            proizvod.IspisiInformacije();
            drugiProizvod.IspisiInformacije();

            ElektronickiUredaj uredaj = new PametniTelefon("Tablet", "Samsung", 2020, "android");
            uredaj.IspisiInformacije();
           
            
            PametniTelefon pametniUredaj = (PametniTelefon)uredaj;
            pametniUredaj.InstalirajAplikaciju("Netflix");
        }
    }
}