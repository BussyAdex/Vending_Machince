namespace Vending_Machince.Model
{
    internal abstract class Coins
    {
        private int quantity;
        private double value ;
        private Coins nextCoin;
        public Coins(int q, double n, Coins nc)
        {
            quantity = q;
             value = n;
            nextCoin = nc;
        }

        public Coins(int q, double n)
        {
            quantity = q;
            value = n;
            nextCoin = null;
        }


        public int GetCoinQuantity()
        {
            return quantity;
        }
        public void SetCoinQuantity(int q)
        {
            quantity = q;
        }
        
        public double GetCoinValue()
        {
            return value;
        }

        public void SetCoinValue(double n)
        {
            value = n;
        }

        public Coins GetNextCoin()
        {
            return nextCoin;
        }

        public void SetNextCoin(Coins cn) 
        {
            nextCoin = cn;
        }

        public abstract void Total();
    }
}
