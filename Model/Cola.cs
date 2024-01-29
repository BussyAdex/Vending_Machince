namespace Vending_Machince.Model
{
    internal class Cola : Snacks
    {
        public Cola(double pr, int pq)
            : base(pr, pq)
        {
            base.SetProductName("Cola");
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
