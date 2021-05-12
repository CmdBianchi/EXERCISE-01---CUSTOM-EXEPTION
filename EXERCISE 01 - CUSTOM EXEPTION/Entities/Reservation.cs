using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___CUSTOM_EXEPTION.Entities {
    //------------------------------- START -------------------------------//
    class Reservation {
        public int RoomNumber { get;  set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        //------------------------------- CONST -------------------------------//  
        public Reservation(){}
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        //------------------------------- MET --------------------------------//    
        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays; //----------------------> CASTING TRANSFORMANDO EM INT
        }
        public string UpdateDates(DateTime checkIn, DateTime checkOut) {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now) {
                return "Error in reservation: must be future dates! ";
            }
             if (checkOut <= checkIn) {
                return "Error ind reservation: must be future dates! ";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }

        public override string ToString() {
            return "Room " + RoomNumber + ", " + CheckIn.ToString("dd/MM/yyyy") + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights";
        }
    }
    //-------------------------------- END -------------------------------//
}
