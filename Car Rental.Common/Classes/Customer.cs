using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Customer : ICustomer
{
    public int Ssn { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Customer(int snn, string fName, string lName) => (Ssn, FirstName, LastName) = (snn, fName, lName);

}
