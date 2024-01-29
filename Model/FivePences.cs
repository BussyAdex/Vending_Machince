namespace Vending_Machince.Model
{
    internal class FivePences : Coins
    {
        public FivePences(int q, double n)
           : base(q, n)
        {
            base.SetCoinValue(0.05);
        }

        public override void Total()
        {
            Console.WriteLine($"Value £{GetCoinValue()} Quantity {GetCoinQuantity()}");
        }
    }
}
