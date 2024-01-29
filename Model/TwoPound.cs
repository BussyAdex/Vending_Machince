namespace Vending_Machince.Model
{
    internal class TwoPound : Coins
    {
        public TwoPound(int q, double n, Coins nc)
          : base(q,n,nc)
        {
            base.SetCoinValue(2.0);     
        }

        public override void Total()
        {
            Console.WriteLine($"Value £{GetCoinValue()} Quantity {GetCoinQuantity()}");
        }

    }
}


