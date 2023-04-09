using System;

namespace employee_demo
{
    public class HourlyEmployee: Employee
    {
private float _payRate= 0;
private int _hoursWorked = 0;
private float payRate;

public float GetPayRate()
{
    return _payRate;
}

public virtual void setPayRate(string _payRate)
{
            this._payRate = payRate;
}
 public int getHoursWorked() 
 {
    return _hoursWorked;
 }
public void setHoursWorked(int _hoursWorked)
{
    _hoursWorked =_hoursWorked;
}  

public override float GetPay()
{
    return _hoursWorked*_payRate;
}

        internal void setName(string v)
        {
            throw new NotImplementedException();
        }
    }

}