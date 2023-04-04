using System;

class electricals
{
    public List<electricals> electricals;
    private object electricals;
    private int i;

    public object Store { get; private set; }

    public electricals(string v)
    {
        electricals = new List<electricals>()
    {
        new electricals("Bush Coupling"),
        new electricals("Chamber Cistern"),
        new electricals("Water Pipes"),
        new electricals("Water Poly Tank"),
        new electricals("Sewage Pipe"),
        new electricals("Compresion Elbow"),
        new electricals("Water Faucet"),
        new electricals("Water Solar Geyser"),
        new electricals("Water Electric Geysers"),
        new electricals("Copper Pipes"),
        new electricals("Conduit Pipes")

    }
}
    public void printMenu()
    {
        Console.WriteLine("Welcome to Asakhe Plumbing");
        Console.WriteLine("1.Print all Products");
        Console.WriteLine("2. Add a Product");
        Console.WriteLine("3. Search a product");
        Console.WriteLine("4. Remove a product");
        Console.WriteLine("5.Save to Cart");
        Console.WriteLine("6.Exit");

        Console.Write("Enter your Menu option:");
        bool TryParse = int.TryParse(Console.ReadLine(), out int menuOption);
        if (TryParse)
        {
            Console.WriteLine(menuOption);
            if (menuOption == 1)
            {
                PrintAll();

            }
            else if (menuOption == 2)
            {
                AddProduct();

            }
            else if (menuOption == 3)
            {
                EditProduct();
            }
            else if (menuOption == 4)
            {
                RemoveProduct();
            }
            else if (menuOption == 5)
            {
                SaveProduct();
            }
            printMenu();
        }
        else
        {
            Console.WriteLine("Incorrect Menu choice. Try again.");
            Console.WriteLine("Press Enter to try again.");
            Console.ReadLine();
            Console.Clear();
            printMenu();
        }



    public virtual void PrintAll()
    {
        startOption("Printing all Plumbing Products in store " + Environment.NewLine);

        if (products.Count == 0)
        {
            Console.WriteLine("There are no products in the system. Try again.");
        }
        else
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + products[i].returnDetails());
            }



        }
        int i = 0;
        Products.foreach (delegate (Store store))
        {
            i++;
            Console.WriteLine(i + " ." + Store.returnDetails());
        }
        Console.WriteLine("You have finished this option, Press <ENTER> to return to the Menu");
        Console.ReadLine();
        Console.Clear();
    }
    public void AddProduct()
    {
        startOption("Adding a Product");
        try
        {
            Console.Write("Enter name of a product:");
            string NameInput = Console.ReadLine();

            Console.Write("Enter the price of the product:");
            int PriceInput = Convert.ToInt32(Console.ReadLine());
            if (!string.IsNullOrEmpty(NameInput))
            {
                if (PriceInput > 0 && PriceInput < 2000)
                {
                    Products products = new Products(NameInput, PriceInput);
                    products.Add(product);
                    finishOption();
                }


            }
            else
            {
                OutPutMessage("You did not enter a product. Try again.");

                AddProduct();
            }

        }
        catch (Exception)
        {
            OutPutMessage("You have  made a mistake. Press <Enter> to try again");
            AddProduct();
        }

    }
    public void EditProduct()
    {
        startOption("Editing a product");
        if (products.Count == 0)
        {
            Console.WriteLine("No products to edit at this time. please go back to the Menu");

        }
        else
        {
            PrintAllUsers();
            try 
            
            {
               Console.Write("Enter an index:");
            int indexSelection =Convert.ToInt32(Console.ReadLine());
            indexSelection--;

            if (indexSelection>0 && indexSelection<=electricals.Count -1)
            {
                OutPutMessage("Enter a valid selection of an index:");
            }
            }
            catch (Exception)
            {
                OutPutMessage("Something went wrong!");
                EditProduct();
            }
            
        }


    }


    public void RemoveProduct()
    {
        startOption("Removing a Product:");
       






    }
    public void SaveProduct()
    {
        startOption("Save the Product");
        finishOption();


    }
    public void finishOption()
    {
        Console.WriteLine(Environment.NewLine + "You have finished this option, Press <ENTER> to return to the Menu");
        Console.ReadLine();
        Console.Clear();
    }
    public void OutPutMessage(string message)
    {
        Console.WriteLine(message + "Press <Enter> to try again");
        Console.ReadLine();
        Console.Clear();
    }
    public void startOption(string message)
    {
        Console.Clear();
        Console.WriteLine(message + Environment.NewLine);
    }

    private void PrintAllUsers()
    {
        for (int i = 0; i < Products.Count; i++)
        {
            Console.WriteLine(i + 1 + "." + electricals[i].returnDetails());
        }
    }


    //intMenuOption =Convert.ToInt32(Console.ReadLine()) ;


}



public class electricals
{
    private string products;

    public electricals(string products, string NameInput, int priceInput)
    {
        this.products = products;
    }

    public electricals(string NameInput, int priceInput)
    {
        this.NameInput = NameInput;
        this.PriceInput = PriceInput;
    }

    public Products(string products)
    {
    }

    public string NameInput { get; }
    public string PriceInput { get; }
    public static int Count { get; private set; }

    i
}