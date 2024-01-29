
namespace Vending_Machince.Model
{
    internal class FiftyPences : Coins
    {
        public FiftyPences(int q, double n, Coins nc)
          : base(q, n, nc)
        {
            base.SetCoinValue(0.50);
        }

        public override void Total()
        {
            Console.WriteLine($"Value £{GetCoinValue()} Quantity {GetCoinQuantity()}");
        }
    }
}
