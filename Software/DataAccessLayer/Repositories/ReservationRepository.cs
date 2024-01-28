using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ReservationRepository
    {

        public void AddReservation(Reservation reservation) {
            using(var context = new Database())
            {
                context.Reservations.Add(reservation);
                context.SaveChanges();
            }
        }

        public List<Reservation> GetReservations()
        {
            using(var context = new Database())
            {
                var query = from r in context.Reservations
                            select r;

                return query.ToList();
            }
        }
    }
}
