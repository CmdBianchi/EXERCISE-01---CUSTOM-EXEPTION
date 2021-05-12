using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_01___CUSTOM_EXEPTION.Entities {
    //------------------------------- START -------------------------------//
    class Reservation {
        public int RoomNumber { get; set; }
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
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString() {
            return "Room " + RoomNumber + ", " + CheckIn.ToString("dd/MM/yyyy") + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights";
        }
    }
    //-------------------------------- END -------------------------------//
}
