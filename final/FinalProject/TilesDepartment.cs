public class TilesDepartment : Store
{
    private int setPriceRate = 25;

    public string customerDetails = ("Simbhele Tshoba");
    private int nationalId = (1234532);
    public string setName = ("Asakhe Tiles Deapartment");

    public int GetPriceRate(int setPriceRate)
    {
        return setPriceRate;
    }

    private int void  setPriceRate(int priceRate)
    {
        _priceRate = priceRate;
    }

    protected virtual string GetCustomerDetails()
    {
        return customerDetails;
    }
    protected void SetCustomerDetails(string customerDetails)
    {
        _customerDetails = customerDetails;
    }
    private int GetNationalId()
    {
        return nationalId;
    }

    private int SetNationalId(int nationalId)
    {
        _nationalId = nationalId;
    }




}


