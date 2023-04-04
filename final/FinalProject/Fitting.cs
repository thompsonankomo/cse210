using System;

class fitting
{
    public List<Products> products;
    private object product;
    private int i;

    public object Store { get; private set; }

    public fitting()
{
        fitting fitting = new List<fitting>()
    {
        new fitting("Bush Coupling"),
        new fitting("Chamber Cistern"),
        new fitting("Water Pipes"),
        new fitting("Water Poly Tank"),
        new fitting("Sewage Pipe"),
        new fitting("Compresion Elbow"),
        new fitting("Water Faucet"),
        new fitting("Water Solar Geyser"),
        new fitting("Water Electric Geysers"),
        new fitting("Copper Pipes"),
        new fitting("Conduit Pipes");
    

    
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

        if (fitting.Count == 0)
        {
            Console.WriteLine("There are no products in the system. Try again.");
        }
        else
        {
            for (int i = 0; i < fitting.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + fitting[i].returnDetails());
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
                    Products products = new fittings(NameInput, PriceInput);
                    products.Add(fittings);
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

            if (indexSelection>0 && indexSelection<=products.Count -1)
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
        for (int i = 0; i < fitting.Count; i++)
        {
            Console.WriteLine(i + 1 + "." + fitting[i].returnDetails());
        }
    }


    //intMenuOption =Convert.ToInt32(Console.ReadLine()) ;


}



public class fitting
{
    private string products;

    public fitting(string products, string NameInput, int priceInput)
    {
        this.products = products;
    }

    public fitting(string NameInput, int priceInput)
    {
        this.NameInput = NameInput;
        this.PriceInput = PriceInput;
    }

    public fitting(string products)
    {
    }

    public string NameInput { get; }
    public string PriceInput { get; }
    public static int Count { get; private set; }

    

}