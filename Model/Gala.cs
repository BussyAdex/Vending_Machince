namespace Vending_Machince.Model
{
    internal class Gala : Snacks
    {
        public Gala(double pr, int pq)
           : base(pr, pq)
        {
            base.SetProductName("Gala");
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
