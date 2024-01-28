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
    }
}
