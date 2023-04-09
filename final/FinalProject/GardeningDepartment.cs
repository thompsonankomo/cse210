class GardeningDepartment : Store
{
    private int setPriceRate = 0;
    public string CustomerName =("John Peter");
     public int WarrantyTools = (4);


    public string GetCustomerName()
    {
        return CustomerName;
    }
    public void SetCustomerName(string CustomerName)
    {
        _CustomerName =CustomerName;
    }

    public int GetWarrantyTools()
    {
        return WarrantyTools;
    }
    public int SetWarrantyTools( int WarrantyTools)
    {
        _WarrantyTools =WarrantyTools;
    }
     private int GetPriceRate()
     {
        return _priceRate;
     }
     private int  setPriceRate(int priceRate)
     {
        _priceRate = priceRate;
     }

    internal void addProduct()
    {
        throw new NotImplementedException();
    }
}