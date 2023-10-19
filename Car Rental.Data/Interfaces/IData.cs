using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Data.Interfaces;

public interface IData
{
    public List<T>? GetList<T>();
	public List<ICustomer> Customers {get; }
    public List<IVehicle> Vehicles { get; }
    public List<IBooking> Bookings { get; }

    public int NextVehicleId { get; }
    public int NextBookingId { get; }

    public void Add<T>(List<T> data, T item);
	public T? GetSingle<T>(Func<T, bool>? expression);
}
