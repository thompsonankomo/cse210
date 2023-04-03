using System;
using System.Collections.Generic;

class program
{
    class store
    {
        public string name;
        public string customerDetails{get; protected set;}
        public string departments{get; set;}
        public string menu;
        public int priceOfProducts{get; set;}

        public store(string name, string customerDetails,string departments, string menu, int priceOfProducts)
         {
            this.name = name;
            this.customerDetails= customerDetails;
            this.departments=departments;
            this.menu = menu;
            this.priceOfProducts= priceOfProducts;
         }
         private void setName(string name)
         {
            this.name = name;
         }
         private void setCustomerDetails(string customerDetails)
         {
            this.customerDetails = customerDetails;
         }
         public void setDepartments(string departments)
         {
            this.departments = departments;
         }
         public void setMenu(string menu)
         {
            this.menu = menu;
         }
         static void  Main(string[]args)
         {
            store store = new store("Asakhe Hardware");
            store.setName("Asakhe Hardware");
            store.setCustomerDetails("");
            store.setMenu("");
            store.setDepartments("");
            Console.WriteLine(store.returnDetails());
            Console.ReadLine();

         }


          
         

    

        


        

        


    }

}