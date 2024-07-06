using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ReservationService
    {
        public List<Reservation> GetReservationByVehicle(int id)
        {
            using (var repo = new ReservationRepository())
            {
                return repo.GetReservationsByVehicle(id).ToList();
            }
        }
        public List<Reservation> GetReservationByCustomer(int id)
        {
            using (var repo = new ReservationRepository())
            {
                return repo.GetReservationsByCustomer(id).ToList();
            }
        }

        public List<Reservation> GetTransactionsBasedOnCompletion(bool completed)
        {
            using (var repo = new ReservationRepository())
            {
                return repo.GetTransactionByCompletion(completed).ToList();
            }
        }

        public bool CheckIfCompleted(Reservation reservation)
        {
            return reservation.returnLocation != null;
        }

        public void PrintToPdf()
        {

        }

        public void AddReservation(Reservation reservation)
        {
            var reservationRepository = new ReservationRepository();

            reservationRepository.AddReservation(reservation);
        }

        public bool AddNewReservation(Reservation reservation)
        {
            bool isSuccessful = false;
            using (var repo = new ReservationRepository())
            {
                int affectedRows = repo.Add(reservation);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;

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

        public void DeleteReservation(Reservation reservation)
        {
            var reservationRepository = new ReservationRepository();

            reservationRepository.DeleteReservation(reservation);
        }
        public bool RemoveReservation(Reservation reservation)
        {
            bool isSuccessful = false;
            using (var repo = new ReservationRepository())
            {
                int affectedRows = repo.Remove(reservation);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public List<Reservation> ReplaceIDs(List<Reservation> listOfReservations)
        {
            List<Reservation> idReplacedList = new List<Reservation>();

            foreach (var reservation in listOfReservations)
            {
                reservation.Customer = new CustomerRepository().GetCustomerById(reservation.customerID).ToList<Customer>()[0];
                reservation.Vehicle = new VehicleRepository().GetVehicleById(reservation.vehicleID).ToList<Vehicle>()[0];
                idReplacedList.Add(reservation);
            }
            return listOfReservations;
        }

        public List<Reservation> GetFilteredReservations(string filterType, string filterValue, int vehicleId)
        {
            var reservationRepository = new ReservationRepository();

            var filteredReservations = reservationRepository.GetFilteredReservations( filterType,  filterValue,  vehicleId);

            return filteredReservations;
        }



        public List<Reservation> GetAllReservations()
        {
            using (var repo = new ReservationRepository())
            {
                return repo.GetAll().ToList();
            }
        }
    }
}
