using System;

namespace QuickKartBL;

public class Customer
{
    // Instance varible follows camel casing.
    public string Address { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerType { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string EmailId { get; set; }
    public string Gender { get; set; }
    public string Password { get; set; }
    public Customer(int customerId, string customerName, string address, DateTime dateOfBirth, string emailId, string gender, string password, string customerType)
    {
        this.CustomerId = customerId;
        this.CustomerName = customerName;
        this.Address = address;
        this.DateOfBirth = dateOfBirth;
        this.EmailId = emailId;
        this.Gender = gender;
        this.Password = password;
        this.CustomerType = customerType;       
    }
    public double GetDiscount(){
        double discount;
        if (this.CustomerType.Equals("Privileged"))
            discount = 2;
        else if (this.CustomerType.Equals("Regular"))
            discount = 5;
        else if (this.CustomerType.Equals("Elite"))
            discount = 7;
        else
            discount = 0;
        
        return discount;
    }
}
