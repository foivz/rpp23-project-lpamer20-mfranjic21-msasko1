using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class ReservationRepository : Repository<Reservation>
    {
        public ReservationRepository() : base(new Database())
        {
        }
        public override int Update(Reservation entity, bool saveChanges = true)
        {
            var reservation = Entities.SingleOrDefault(r => r.id == entity.id);

            reservation.customerID = entity.customerID;
            reservation.vehicleID = entity.vehicleID;
            reservation.pickupDate = entity.pickupDate;
            reservation.returnDate = entity.returnDate;
            reservation.pickupLocation = entity.pickupLocation;
            reservation.returnLocation = entity.returnLocation;
            reservation.totalCost = entity.totalCost;
            reservation.creationDate = entity.creationDate;
            reservation.status = entity.status;
            reservation.Customer = entity.Customer;
            reservation.Vehicle = entity.Vehicle;

            if (saveChanges)
            {
                return SaveChanges();
            } else
            {
                return 0;
            }
        }

        public override IQueryable<Reservation> GetAll()
        {
            var query = from r in Entities
                        select r;
            return query;
        }

        public IQueryable<Reservation> GetReservationsByCustomer(int id)
        {
            var query = from r in Entities
                        where r.Customer.id == id
                        select r;

            return query;
        }

        public IQueryable<Reservation> GetReservationsByVehicle(int id)
        {
            var query = from r in Entities
                        where r.Vehicle.id == id
                        select r;

            return query;
        }

        public IQueryable<Reservation> GetTransactionByCompletion(bool completed)
        {
            var query = from r in Entities
                        where (r.returnLocation != null) == completed
                        select r;

            return query;
        }
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
