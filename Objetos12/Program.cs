using System;

namespace objetos12
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);
            room.RoomSoldOutEvent += OnRoomSoldOut;
                
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            
        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada");
        }
    }

    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
        }

        private int seatsInUse = 0;
        public int Seats { get; set; }

        public void ReserveSeat()
        {
            seatsInUse++;
            if (seatsInUse >= Seats)
            {
                OnRooomSoltOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento reservado");
            }
        }

        public event EventHandler RoomSoldOutEvent;

        protected virtual void OnRooomSoltOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);
        }
    }
}

