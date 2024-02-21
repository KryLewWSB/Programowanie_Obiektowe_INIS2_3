using ConsoleApp4;

List<Osoba> listaOsob = new List<Osoba>();
listaOsob.Add(new Osoba("Adam", "Nowak",500_500_500));//Deklaracja zmiennej obiektowej typu Osoba. I utworzenie w zmiennej nowego obiektu.
listaOsob.Add( new Osoba("Monika", "Nowak",500_500_500));
listaOsob.Add( new Osoba("Maria", "Kowal",500_500_500));
listaOsob.Add( new Osoba("Anna", "Kowalska",500_500_500));


foreach (var osoba in listaOsob)
{
    osoba.pobierzInformacje();
}


int liczba = 5;//Deklaracja zmiennej i typu int, oraz incjalizacja (przypisanie wartości 5)


