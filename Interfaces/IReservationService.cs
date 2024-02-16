using ReservationsApp.Models;

namespace ReservationsApp.Interfaces
{
    public interface IReservationService 
    {
        int AddReservation(Reservation model);
        List<Reservation> FindAllReservations();
    }
}
