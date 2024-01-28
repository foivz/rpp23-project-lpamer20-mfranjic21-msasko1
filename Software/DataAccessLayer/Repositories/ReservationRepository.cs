using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public void UpdateReservation(Reservation reservation)
        {
            using(var context = new Database())
            {
                Reservation existingReservation = context.Reservations.Find(reservation.id);
                if (existingReservation != null)
                {
                    context.Reservations.AddOrUpdate(reservation);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteReservation(Reservation reservation)
        {
            using (var context = new Database())
            {         
                
                Reservation existingReservation = context.Reservations.Find(reservation.id);
                if (existingReservation != null)
                {
                    context.Reservations.Remove(existingReservation);
                    context.SaveChanges();
                }
                
            }
        }
    }
}
