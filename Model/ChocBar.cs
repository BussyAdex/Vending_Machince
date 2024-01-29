namespace Vending_Machince.Model
{
    internal class ChocBar : Snacks
    {
        public ChocBar(double pr, int pq)
            : base(pr, pq)
        {
            base.SetProductName("ChocBar");
            base.SetProductPrice(pr);
            base.SetProductQuantity(pq);
        }     

        public override void Display()
        {
            Console.WriteLine("Name : " + GetProductName());
            Console.WriteLine("Price : £" + GetProductPrice().ToString());
            Console.WriteLine("Quantity : " + GetProductQuantity().ToString());
        }
    }
}
