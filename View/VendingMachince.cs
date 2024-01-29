using Vending_Machince.Controller;
namespace Vending_Machince.View
{
    class VendingMachince 
    {
        public VendingMachince() { }

        public void Start()
        {
            MachinceController controller = new MachinceController();
            controller.Create();
            controller.Change();
            int main = 0;
            while (main < 1)
            {
                Console.WriteLine("#################################################");
                Console.WriteLine(" #     Mecachrome Vending Merchant             # ");
                Console.WriteLine("   #   Hawking Edibles Wares                 # ");
                Console.WriteLine("#################################################");

                int value1;
                int value2;
                int j = 0;


                Console.WriteLine("    Snack     --   Price    --  QTY ");
                controller.View();


                while (j < 1)
                {
                    Console.WriteLine("Please enter choice : ");
                    string val = Console.ReadLine();
                    if (val != null)
                    {
                        try
                        {
                            value1 = int.Parse(val);
                            if (value1 > -1 && value1 < 6)
                            {
                                Console.WriteLine($"Good Input -> You want Item {value1}");
                                if (value1 == 1)
                                {
                                     Console.WriteLine("You are buying Cola");
                                    if (controller.IsQuantity(1)) 
                                    {
                                        if (controller.Payment(1))
                                        {
                                            controller.ReduceSnack(1);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("We are Out of Stock");
                                        Console.WriteLine("Please try another product");
                                    }
                                      
                                }
                                else if (value1 == 2)
                                {
                                    Console.WriteLine("You are buying Choc Bar");
                                    if (controller.IsQuantity(2))
                                    {
                                        if (controller.Payment(2))
                                        {
                                            controller.ReduceSnack(2);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("We are Out of Stock");
                                        Console.WriteLine("Please try another product");
                                    }
                                }
                                else if (value1 == 3)
                                {
                                    Console.WriteLine("You are buying Skittles");
                                    if (controller.IsQuantity(3))
                                    {
                                        if (controller.Payment(3))
                                        {
                                            controller.ReduceSnack(3);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("We are Out of Stock");
                                        Console.WriteLine("Please try another product");
                                    }
                                }
                                else if (value1 == 4)
                                {
                                    Console.WriteLine("You are buying Bikkies");
                                    if (controller.IsQuantity(4))
                                    {
                                        if (controller.Payment(4))
                                        {
                                            controller.ReduceSnack(4);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("We are Out of Stock");
                                        Console.WriteLine("Please try another product");
                                    }
                                }
                                else if (value1 == 5)
                                {
                                    Console.WriteLine("You are buying Gala");
                                    if (controller.IsQuantity(5))
                                    {
                                        if (controller.Payment(5))
                                        {
                                            controller.ReduceSnack(5);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("We are Out of Stock");
                                        Console.WriteLine("Please try another product");
                                    }
                                }
                                else 
                                {
                              
                                    int a = 0;
                                    while (a < 1)
                                    {
                                        Console.WriteLine("You are an admin");
                                        Console.WriteLine("Please enter your password : ");
                                        string userName = Console.ReadLine();
                                        if (!string.IsNullOrEmpty(userName))
                                        {
                                            if (userName.Trim() == "A5144l")
                                            {
                                                
                                                Console.WriteLine("Password correct");
                                                Console.WriteLine("Please enter your pin : ");
                                                string passWord = Console.ReadLine();
                                                if (!string.IsNullOrEmpty(passWord))
                                                {
                                                    if (passWord.Trim() == "1011")
                                                    {
                                                        Console.WriteLine("Welcome Admin");
                                                        controller.AdminView();
                                                        a++;
                                                        int b = 0;
                                                        while (b < 1)
                                                        {
                                                            Console.WriteLine("Please enter choice : ");
                                                            string val2 = Console.ReadLine();
                                                            if (val2 != null)
                                                            {
                                                                try
                                                                {
                                                                    value2 = int.Parse(val2);
                                                                    if (value2 > 0 && value1 < 4) 
                                                                    {
                                                                        if (value2 == 1) 
                                                                        {
                                                                            Console.WriteLine($" You input {value2}");
                                                                            Console.WriteLine("To increase the price. \n" +
                                                                                 " Input product name and quatity");
                                                                            Console.WriteLine("Insert product name : ");
                                                                            string prodName = Console.ReadLine();
                                                                            Console.WriteLine("Insert new price -> format: 2.0 :");
                                                                            string val5 = Console.ReadLine();
                                                                            double prodQuan;
                                                                            try 
                                                                            {
                                                                               prodQuan = double.Parse(val5);
                                                                                bool priceUpdate = controller.SnackPrice(prodName, prodQuan);
                                                                                if (priceUpdate)
                                                                                {
                                                                                    Console.WriteLine("Change update Successful");
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Error ocurred while updating");
                                                                                }
                                                                            }
                                                                            catch (SystemException ex)
                                                                            {
                                                                                Console.WriteLine("Execepetion Message: " + ex.Message);
                                                                                Console.WriteLine("please input a valid value");
                                                                            }

                                                                            Console.WriteLine("Press enter to continue");
                                                                            b = b + 1;
                                                                        }
                                                                        else if (value2 == 2)
                                                                        {
                                                                            Console.WriteLine($" You input {value2}");
                                                                            Console.WriteLine("To increase the pool. \n" +
                                                                                 " Input currency and quatity");
                                                                            Console.WriteLine("Currency in figure -> format 2.0 : ");
                                                                            string val3 = Console.ReadLine();
                                                                            Console.WriteLine("Insert quantity : ");
                                                                            string val4 = Console.ReadLine();
                                                                            double currency;
                                                                            int quantity;
                                                                            try
                                                                            { 
                                                                                currency = double.Parse(val3);
                                                                                quantity = int.Parse(val4);
                                                                                bool increase = controller.ChangeIncrease(currency,quantity);
                                                                                if (increase)
                                                                                {
                                                                                    Console.WriteLine("Change update Successful");
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine("Error ocurred while updating");
                                                                                }
                                                                            }
                                                                            catch (SystemException ex)
                                                                            {
                                                                                Console.WriteLine("Execepetion Message: " + ex.Message);
                                                                                Console.WriteLine("please input a valid value");
                                                                            }
                                                                            Console.WriteLine("Press enter to continue");
                                                                            b = b + 1;
                                                                        }
                                                                        else if (value2 == 3)
                                                                        {
                                                                            Console.WriteLine($" You input {value2}");
                                                                            controller.ChangeTotal();
                                                                            Console.WriteLine("Press enter to continue");
                                                                            b = b + 1;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("Enter number within range");
                                                                        }

                                                                    } 
                                                                }
                                                                catch (SystemException ex)
                                                                {
                                                                    Console.WriteLine("Execepetion Message: " + ex.Message);
                                                                    Console.WriteLine("please input a valid value");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("No input");
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Wrong pin");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("LOL -- Empty pin");
                                                }
                                            }
                                            else 
                                            {
                                                Console.WriteLine("Incorrect password");
                                            }                                                
                                        }
                                        else 
                                        {
                                            Console.WriteLine("No password input");
                                        }
                                    }
                                }
                                j++;
                            }
                            else
                            {
                                Console.WriteLine("Enter a number within range");
                                j = 0;
                            }
                        }
                        catch (SystemException ex)
                        {
                            Console.WriteLine("Execepetion Message: " + ex.Message);
                            Console.WriteLine("please input a valid value");
                        }
                    }
                    else
                    {
                        Console.WriteLine("please input a value - Input Empty");
                    }
                }
                Console.ReadLine();
            }
        }
    } 
}