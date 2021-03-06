﻿using System;
using Domain.Aggregates.Cinemas;

namespace Domain.Aggregates.Sessions
{
    public class Ticket
    {
        protected Ticket() { }

        public Ticket(SessionSeat sessionSeat, decimal price)
        {
            if (sessionSeat == null)
            {
                throw new ArgumentNullException(nameof(sessionSeat));
            }

            if (price <= 0M)
            {
                throw new ArgumentOutOfRangeException(nameof(price));
            }

            SessionSeat = sessionSeat;
            SessionId = SessionSeat.SessionId;
            SeatId = SessionSeat.SeatId;
            Price = price;
        }

        public int SessionId { get; private set; }

        public int SeatId { get; private set; }

        public SessionSeat SessionSeat { get; private set; }
        
        public decimal Price { get; private set; }
    }
}