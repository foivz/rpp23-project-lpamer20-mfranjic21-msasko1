using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ReservationService
    {
        public void AddReservation(Reservation reservation)
        {
            var reservationRepository = new ReservationRepository();

            reservationRepository.AddReservation(reservation);
        }

        public List<Reservation> GetReservations() {
            var reservationRepository = new ReservationRepository();

            var reservations = reservationRepository.GetReservations();

            return reservations;
        }

        public void UpdateReservation(Reservation reservation)
        {
            var reservationRepository = new ReservationRepository();

            reservationRepository.UpdateReservation(reservation);
        }
    }
}
