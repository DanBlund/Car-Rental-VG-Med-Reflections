﻿namespace Car_Rental.Common.Interfaces;

public interface ICustomer
{
    public int Ssn { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
