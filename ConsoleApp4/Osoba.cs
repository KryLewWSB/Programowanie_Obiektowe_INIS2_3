namespace ConsoleApp4;

public class Osoba
{
    public string imie;
    public string nazwisko;
    public int numerTelefonu;
    public Osoba(string imie, string nazwisko, int numerTelefonu)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.numerTelefonu = numerTelefonu;
    }
    public void pobierzInformacje()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine($"Imię: {imie}\nNazwisko: {nazwisko}\nTelefon: {numerTelefonu}");
        Console.WriteLine("--------------------------");
    }
}