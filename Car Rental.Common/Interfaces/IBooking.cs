using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    public int Id { get; set; }
    public string RegNumber { get; init; }
    public string Customer { get; init; }
    public int KmRented { get; init; }
    public int? KmReturned { get; set; }
    public DateTime Rented { get; init; }
    public DateTime Returned { get; set; }
    public int? Cost { get; set; }
    public BookingStatuses BookingStatus { get; set; }
}
