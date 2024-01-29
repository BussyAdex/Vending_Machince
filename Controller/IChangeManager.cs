namespace Vending_Machince.Controller
{
    internal interface IChangeManager
    {
        public bool ChangeIncrease(double q, int n);
        public void ChangeTotal();
        public bool IsChange(double ch);
        public bool Payment(int n);
    }
}
