using ReservationsApp.Models;

namespace ReservationsApp.Interfaces
{
    public interface IReservationService 
    {
        int AddReservation(Reservations model);
        List<Reservations> FindAllReservations();
    }
}
