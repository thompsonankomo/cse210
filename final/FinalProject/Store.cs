public abstract class Store
{
    protected string _name;

    protected string _customerDetails;

    public int _priceRate;

    public string  StoreInformation { get; private set; }

    public Store()
    {

    }
    public string GetName()
    {
        return _name;

    }
    public void SetName(string name)
    {
        _name = name;
    }

    protected virtual string GetCustomerDetails()
    {
        return _customerDetails;
    }
    public void setCustomerDetails(string customerDetails)
    {
        _customerDetails =customerDetails;
    }

    public int GetPriceRate()

    {
        return _priceRate;
    }
}
    
