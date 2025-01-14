using System;

class Program
{
    public static void Main()
    {
        Customer C1 = new Customer("Emmanuel", "Ejeagha");
        C1.PrintFullName();
    }
}

class Customer
{
    string _firstName;
    string _lastName;

    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
    }

    ~Customer()
    {
        // clean
    }
}