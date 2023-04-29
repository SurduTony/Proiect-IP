namespace Sali
{
    public class Sali
    {
        protected int _idRestaurant; //id-ul restaurantului (este foreign key)
        protected int _idSala; //numarul de ordine al salii
        protected int _mese; //numarul de mese din sala cu _idSali
        protected string _facilitati; // optiunile pentru sala (ex. pentru nunta, masa afara etc.)
    }
}