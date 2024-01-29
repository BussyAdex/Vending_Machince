namespace Vending_Machince.Model
{
    internal class TenPences : Coins
    {
        public TenPences(int q, double n, Coins nc)
          : base(q, n, nc)
        {
            base.SetCoinValue(0.10);
        }

        public override void Total()
        {
            Console.WriteLine($"Value £{GetCoinValue()} Quantity {GetCoinQuantity()}");
        }
    }
}
