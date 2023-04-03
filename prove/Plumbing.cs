using System;

class plumbing
{
 public List <Products> plumbing
 {
 
 }
 public void printMenu()
 {
    Console.WriteLine("Welcome to Asakhe Plumbing");
    Console.WriteLine("1.Print all Porducts");
    Console.WriteLine("2. Add a Product");
    Console.WriteLine("3. Search a product");
    Console.WriteLine("4. Remove a product");
    Console.WriteLine("5.Save to Cart");
    Console.WriteLine("6.Exit");

    Console.Write("Enter your Menu option:");
    bool TryParse =int.TryParse(Console.ReadLine(), out int menuOption);
    if(TryParse)
    {
      Console.WriteLine(menuOption);
      if (menuOption == 1)
      {
        PrintAll();
      }
      else if(menuOption == 2)
      {
        AddProduct();

      }
      else if(menuOption == 3)
      {
        SearchProduct();
      }
      else if (menuOption == 4)
      {
        RemoveProduct();
      }
      else if (menuOption == 5)
      {
        SaveProduct();
      }
    }
    else{
        Console.writeline("Incorrect Menu choice. Try again.");
        Cosole.WriteLine("Press Enter to try again.");
        Console.Readline();
        Console.Clear();
        printMenu();
    }
    

    public virtual void PrintAll()
    {

    }
    public void AddProduct()
    {
      Console.WriteLine("Add product");
    }
     public void SearchProduct()
    {
       Console.WriteLine("Search product");
    }
     public void RemoveProduct()
    {
      Console.WriteLine("Remove product");
    }
     public void SaveProduct()
    {
      Console.WriteLine("Save product");
    }
    

    //intMenuOption =Convert.ToInt32(Console.ReadLine()) ;
    
 }
 
}