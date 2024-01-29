namespace Vending_Machince.Controller
{
    internal interface ISnacksManager
    {
        public bool SnackPrice(string n, double q);

        public bool IsQuantity(int n);

        public bool ReduceSnack(int n);
    }
}
