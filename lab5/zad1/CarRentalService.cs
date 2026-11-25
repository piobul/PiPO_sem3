using System;

namespace C5
{
    class CarRentalService
    {
        private CarFactory carFactory;

        public CarRentalService(CarFactory factory)
        {
            carFactory = factory;
        }

        public void Rent()
        {
            Vehicle v = carFactory.Create();
            Console.WriteLine("Our service can offer you the following car today: ");
            Console.WriteLine(v);
        }
    }

    /*
     * 1) Czy programista CarRentalService musi cos zmieniac po zmianie CarFactory?
     *    NIE. Rent() wywoluje tylko carFactory.Create() i korzysta z wyniku jako z Vehicle.
     *    Tylko CarFactory losuje marke/rocznik.
     *
     * 2) Problem przy zwyklym konstruktorze zamiast fabryki:
     *    Gdyby Rent() robil "new Car(...)", to albo
     *      a) serwis musialby sam losowac marke, rocznik itd. - czyli znac szczegoly
     *         tworzenia samochodu
     *      b) losowanie trzeba by wepchnac do konstruktora Car - wtedy klasa Car miesza
     *         swoja role (opis samochodu) z logika "jaki samochod wylosowac".
     *         
     *    Dodatkowo serwis bylby na sztywno zwiazany z konkretna klasa Car (new Car) i nie
     *    dalo by sie go zasilic np. LuxuryCarFactory bez edycji jego kodu.
     *
     * 3) Konstruktor vs fabryka:
     *    Zalety konstruktora: prostszy kod, brak dodatkowych klas, od razu widac co powstaje,
     *    gwarantuje zainicjowanie obiektu konkretnego typu, brak "ceremonii" - dobry gdy
     *    typ i parametry sa znane i stale.
     *    Zalety fabryki: oddziela uzycie obiektu od jego tworzenia,
     *    moze zwracac rozne podtypy i zmieniac logike tworzenia (losowanie, pule obiektow,
     *    konfiguracja) bez zmian w kodzie klienta, ma nazwe opisujaca intencje, latwo ja
     *    podmienic (np. w testach). Wada: wiecej klas i kodu.
     */
}