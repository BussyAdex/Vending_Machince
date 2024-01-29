using Vending_Machince.Model;

namespace Vending_Machince.Controller
{
    class SnackFactory
    { 
       
        public Snacks GetSnack(string snackType)
        {
            if (snackType == null)
            {
                return null;
            }
            if (snackType == "Bikkies")
            {
                return new Bikkies(1.25, 10);

            }
            else if (snackType == "ChocBar")
            {
                return new ChocBar(1.25, 10);

            }
            else if (snackType == "Cola")
            {
                return new Cola(1.50, 10);
            }
            else if (snackType == "Gala")
            {
                return new Gala(1.25, 04);
            }
            else if (snackType == "Skittles")
            {
                return new Skittles(1.70, 08);
            }
            return null;
        }
    }
}
