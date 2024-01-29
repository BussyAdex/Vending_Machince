namespace Vending_Machince.Model
{
    internal class TwentyPences : Coins
    {
        public TwentyPences(int q, double n, Coins nc)
          : base(q, n, nc)
        {
            base.SetCoinValue(0.20);
        }

        public override void Total()
        {
            Console.WriteLine($"Value £{GetCoinValue()} Quantity {GetCoinQuantity()}");
        }
    }
}
