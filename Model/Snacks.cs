namespace Vending_Machince.Model
{
    internal abstract class Snacks
    {
        private string productName;
        private double productPrice;
        private int productQuantity;

        public Snacks(string pN, double pP, int pQ)
        {
            productName = pN;
            productPrice = pP;
            productQuantity = pQ;
        }

        public Snacks(double pP, int pQ)
        {
            productName = "";
            productPrice = pP;
            productQuantity = pQ;
        }

        public string GetProductName()
        {
            return productName;
        }

        public void SetProductName(string pn)
        {
            productName = pn;
        }

        public double GetProductPrice()
        {
            return productPrice;
        }

        public void SetProductPrice(double pp)
        {
            productPrice = pp;
        }

        public int GetProductQuantity()
        {
            return productQuantity;
        }

        public void SetProductQuantity(int pq)
        {
            productQuantity = pq;
        }

        public abstract void Display();

        

    }
}
