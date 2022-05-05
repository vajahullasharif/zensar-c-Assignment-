﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase_test_1

{
    public class TicketsException : Exception
    {
        public TicketsException(string message) : base(message)
        {
        }
    }
    class Passenger
    {
        string name;
        string DateofTravel;
        int Age;
        Passenger(string name, string DateofTravel, int Age)
        {
            this.name = name;
            this.DateofTravel = DateofTravel;
            this.Age = Age;
        }

        public void TicketBooking(int no_of_tickets)
        {
            if (no_of_tickets > 5)
            {
                throw (new TicketsException("No more than 5 tickets"));
            }
            else
            {
                Console.WriteLine("Tickets successfully: {0}", no_of_tickets);

            }
        }

        public static void Main()
        {
            int no_tickets;
            no_tickets = Convert.ToInt32(Console.Read());
            Console.WriteLine(no_tickets);
            Passenger pass = new Passenger("Vajahulla", "5-05-2022", 22);
            pass.TicketBooking(no_tickets);
            
        }
    }
}


    
   


        
    

