namespace Vending_Machince.Model
{
    internal class OnePound : Coins
    {
        public OnePound(int q, double n, Coins nc)
          : base(q, n, nc)
        {
            base.SetCoinValue(1.0);
        }

        public override void Total()
        {
            Console.WriteLine($"Value £{GetCoinValue()} Quantity {GetCoinQuantity()}");
        }
    }
}
