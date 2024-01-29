using Vending_Machince.Model;

namespace Vending_Machince.Controller
{
    public class MachinceController : IChangeManager, ISnacksManager
    {
        private List<Snacks> snackList;
        private List<Coins> changePool;
        public MachinceController()
        {}
        public void Create ()
        {
			try
			{
                SnackFactory snackFactory = new SnackFactory();
                snackList = new List<Snacks>();
                snackList.Add(snackFactory.GetSnack("Cola"));
                snackList.Add(snackFactory.GetSnack("ChocBar"));
                snackList.Add(snackFactory.GetSnack("Skittles"));
                snackList.Add(snackFactory.GetSnack("Bikkies"));
                snackList.Add(snackFactory.GetSnack("Gala"));
               
            }
            catch (SystemException ex)
            {
                Console.WriteLine("Execepetion Message: " + ex.Message);
            }
        }
        public void View()
        {
            if (snackList.Count > 0)
            {
                try
                {
                    int j = 1;
                    foreach (Snacks s in snackList) 
                    {
                        if (s.GetProductName() == "Cola" || s.GetProductName() == "Gala")
                        { 
                            if (s.GetProductQuantity() < 1)
                            {
                                Console.WriteLine($"{j}   {s.GetProductName()}      --   £{s.GetProductPrice()}    --  * Out of stock *");
                            }
                            else
                            {
                                Console.WriteLine($"{j}   {s.GetProductName()}      --   £{s.GetProductPrice()}    --  {s.GetProductQuantity()}");
                            }
                            
                        }
                        else if (s.GetProductName() == "Skittles")
                        {
                            if (s.GetProductQuantity() < 1)
                            {
                                Console.WriteLine($"{j}   {s.GetProductName()}  --   £{s.GetProductPrice()}    --  * Out of stock *");
                            }
                            else
                            {
                                Console.WriteLine($"{j}   {s.GetProductName()}  --   £{s.GetProductPrice()}    --  {s.GetProductQuantity()}");
                            }
                                
                        }
                        else
                        {
                            if (s.GetProductQuantity() < 1) 
                            {
                                Console.WriteLine($"{j}   {s.GetProductName()}   --   £{s.GetProductPrice()}    --  * Out of stock *");
                            }
                            else
                            {
                                Console.WriteLine($"{j}   {s.GetProductName()}   --   £{s.GetProductPrice()}    --  {s.GetProductQuantity()}");
                            }
                                
                        }
                            j = j + 1;
                    }
                }
                catch (SystemException ex)
                {
                    Console.WriteLine("Execepetion Message: " + ex.Message);
                }
            }
            else 
            {
                Console.WriteLine("No snack created");
            }
            Console.WriteLine("Press 0 for admin.");
        }

        public void AdminView() {

            Console.WriteLine("#################################");
            Console.WriteLine("    #     Admin Page     #");
            Console.WriteLine("#################################");
            Console.WriteLine("1 . To change the snack prices ");
            Console.WriteLine("2 . To increase the change pool. ");
            Console.WriteLine("3 . To see the total amount of money presently in the machine ");

        }

        public void Change()
        {
            changePool = new List<Coins>();
            Coins coins1 = new TwoPound(2, 2.0, new OnePound(3, 1.0, new FiftyPences(4, 0.50, new TwentyPences(5, 0.20, new TenPences(10, 0.10, new FivePences(20, 0.05))))));
            Coins coins2 = new OnePound(3, 1.0, new FiftyPences(4, 0.50, new TwentyPences(5, 0.20, new TenPences(10, 0.10, new FivePences(20, 0.05)))));
            Coins coins3 = new FiftyPences(4, 0.50, new TwentyPences(5, 0.20, new TenPences(10, 0.10, new FivePences(20, 0.05))));
            Coins coins4 = new TwentyPences(5, 0.20, new TenPences(10, 0.10, new FivePences(20, 0.05)));
            Coins coins5 = new TenPences(10, 0.10, new FivePences(20, 0.05));
            Coins coins6 = new FivePences(20, 0.05);
            changePool.Add(coins1);
            changePool.Add(coins2);    
            changePool.Add(coins3);
            changePool.Add(coins4);
            changePool.Add(coins5);
            changePool.Add(coins6);
        }

        public void ChangeTotal()
        {
            double actVal = 0;
            Console.WriteLine("Total change in machince");
            foreach (Coins c in changePool) 
            {
                c.Total();
                actVal =  Math.Round(actVal,2) + Math.Round((c.GetCoinValue() * c.GetCoinQuantity()), 2);
            }
            Console.WriteLine($"Total amount is £{actVal}");
        }

        public bool ChangeIncrease(double q, int n) 
        { 
            foreach(Coins cn in changePool) 
            {
                if (cn.GetCoinValue() == q) 
                {
                    int quan = cn.GetCoinQuantity();
                    quan = (quan + n);
                    cn.SetCoinQuantity(quan);
                    return true;
                }
            }  
     
            return false;
        }

        public bool SnackPrice(string n, double q)
        {
            foreach(Snacks sn in snackList)
                if (sn.GetProductName().ToLower() == n.ToLower()) 
                { 
                    sn.SetProductPrice(q);
                    return true;
                }
            return false;
        }

        public bool Payment(int n)
        {
            int i = 1;
            double diff = -1 ;
            foreach(Snacks sn in snackList) 
            { 
                if (i == n)
                {
                    double price = sn.GetProductPrice();
                    Console.WriteLine($"Input amount up to £{price} ");
                    IDictionary<double, int> paymentCoins = new Dictionary<double, int>();
                    double amount = 0.0;
                    double amt =0.0;
                    while (price > amount)
                    { 
                        Console.WriteLine("Select your coin denomination");
                        Console.WriteLine("Number   Value");
                        Console.WriteLine("  1   =  £2.00");
                        Console.WriteLine("  2   =  £1.00 ");
                        Console.WriteLine("  3   =  £0.50 ");
                        Console.WriteLine("  4   =  £0.20 ");
                        Console.WriteLine("  5   =  £0.10 ");
                        Console.WriteLine("  6   =  £0.05 ");
                        Console.WriteLine("Enter number for choice : ");
                        string val6 = Console.ReadLine();

                        Console.WriteLine("Type in your coin quantity : ");
                        string val7 = Console.ReadLine();

                        try 
                        {
                            double deno = double.Parse(val6);
                            
                            if (deno == 1.0)
                            {
                                amt = 2.0;
                            }
                            else if (deno == 2.0)
                            { amt = 1.0; }
                            else if (deno == 3.0)
                            { amt = 0.50; }
                            else if (deno == 4.0)
                            { amt = 0.20; }
                            else if (deno == 5.0)
                            { amt = 0.10; }
                            else if (deno == 6.0)
                            { amt = 0.05; }
                            else { amt = 0.0; }
                            
                            int qua  = int.Parse(val7);
                            
                            paymentCoins.Add(amt, qua);
                            
                            foreach (KeyValuePair<double, int> pair in paymentCoins)
                            {
                                amount = Math.Round(amount,2) + Math.Round((pair.Key * pair.Value), 2);
                            }
                            Console.WriteLine($"Your amount is £{amount}");
                            
                            if (amount >= price)
                            {

                                diff = Math.Round((amount - price), 2);
                                Console.WriteLine($"Your change is £{diff}");
                                if (IsChange(diff)) 
                                {
                                    foreach (KeyValuePair<double, int> pair in paymentCoins)
                                    {
                                        double money = pair.Key;
                                        int moneyVal = pair.Value;
                                        int hold;
                                        switch (money) 
                                        {
                                            case (2.0):
                                                hold = changePool[0].GetCoinQuantity();
                                                hold = (hold + moneyVal);
                                                changePool[0].SetCoinQuantity(hold);
                                                break;
                                            case (1.0):
                                                hold = changePool[1].GetCoinQuantity();
                                                hold = (hold + moneyVal);
                                                changePool[1].SetCoinQuantity(hold);
                                                break;
                                            case (0.50):
                                                hold = changePool[2].GetCoinQuantity();
                                                hold = (hold + moneyVal);
                                                changePool[2].SetCoinQuantity(hold);
                                                break;
                                            case (0.20):
                                                hold = changePool[3].GetCoinQuantity();
                                                hold = (hold + moneyVal);
                                                changePool[3].SetCoinQuantity(hold);
                                                break;
                                            case (0.10):
                                                hold = changePool[4].GetCoinQuantity();
                                                hold = (hold + moneyVal);
                                                changePool[4].SetCoinQuantity(hold);
                                                break;
                                            case (0.05):
                                                hold = changePool[5].GetCoinQuantity();
                                                hold = (hold + moneyVal);
                                                changePool[5].SetCoinQuantity(hold);
                                                break;
                                            default:
                                                Console.WriteLine("No value match as the denomination is not available");
                                                return false;
                                                break;
                                        }
                                        return true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("**************************************************");
                                    Console.WriteLine("We are sorry.\n" +
                                        "We would not be able to continue this transaction.\n" +
                                        "This machince has no change at the moment.\n" +
                                        "Please input a lesser amount");
                                    Console.WriteLine("**************************************************");
                                    return false;
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine("please keep adding to top up");
                                amount = 0.0;
                            }
                        }
                        catch (SystemException ex)
                        {
                            Console.WriteLine("Execepetion Message: " + ex.Message);
                            Console.WriteLine("please input a valid value");
                        }

                    }
                }
                i++;
            }
            
            return false;
        }

        public bool IsQuantity(int n)
        {
            int i = 1;
            foreach (Snacks sn in snackList)
            {
                if (i == n)
                {
                    if (sn.GetProductQuantity() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                i++;
            }

            return false;
        }
        public bool IsChange(double ch) 
        {
            double changeBal = ch;
            double changeBalTake = ch;
            double remBal = 0;
            if (changeBal > 0)
            {
                //Get Total Bal 
                foreach (Coins cr in changePool)
                {
                    remBal = Math.Round(remBal, 2) + Math.Round((cr.GetCoinValue() * cr.GetCoinQuantity()), 2);
                }
                if (remBal > changeBal)
                {
                    //To check if payable
                    foreach (Coins cn in changePool)
                    {
                        double actVal = Math.Round((cn.GetCoinValue() * cn.GetCoinQuantity()), 2);
                        if (actVal > 0.0 && changeBal > 0.0)
                        {
                            double take = Math.Round((changeBal / cn.GetCoinValue()), 2);
                            changeBal = Math.Round((changeBal % cn.GetCoinValue()), 2);
                        }
                    }
                    if (changeBal == 0.0)
                    {
                        //To remove from pool
                        Console.WriteLine("*******************************");
                        Console.WriteLine("    ***Change Presented***     ");
                        Console.WriteLine(" *Value*    *Quantity*");
                        
                        foreach (Coins cn in changePool)
                        {
                            double actVal = Math.Round((cn.GetCoinValue() * cn.GetCoinQuantity()), 2);
                            if (actVal > 0.0 && changeBalTake > 0.0)
                            {
                                double intake = Math.Round((changeBalTake / cn.GetCoinValue()), 2);
                                int take = (int)intake;
                                int rem = cn.GetCoinQuantity();
                                changeBalTake = changeBalTake % cn.GetCoinValue();
                                if (take > 0)
                                {
                                    rem = rem - (int)take;
                                    cn.SetCoinQuantity(rem);
                                    Console.WriteLine($"  £{cn.GetCoinValue()}        {take}");
                                }
                            }
                        }
                        Console.WriteLine("*******************************");
                        Console.WriteLine("===== Snacks Presented    =====");
                        Console.WriteLine(">>>>Please take your snacks<<<<");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"No change for the amount inputed. \n" +
                            $" amount outstanding is {changeBal}");
                     
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("No change in the machince");
                    return false;
                }

            }
            else {
                Console.WriteLine("*******************************");
                Console.WriteLine("   **You have no change**");
                Console.WriteLine("*******************************");
                Console.WriteLine("===== Snacks Presented    =====");
                Console.WriteLine(">>>>Please take your snacks<<<<");
                return true;
            }
            
        }
        
        public bool ReduceSnack(int n) 
        {
            int i = 1;
            foreach(Snacks sn in snackList)
            {
                if (i == n) 
                {
                    int numb = sn.GetProductQuantity();
                    numb = numb - 1;
                    sn.SetProductQuantity(numb);
                }
                i++;
            }
            return false;
        }
    }
}
