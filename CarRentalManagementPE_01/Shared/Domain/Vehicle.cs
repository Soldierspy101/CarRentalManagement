﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagementPE_01.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set; }
        public string? LicencePlateNumber { get; set; }
        public int MakeId { get; set; }
        public virtual Make? Make { get; set; }
        public int ModelId { get; set; }
        public virtual Model? Model { get; set; }
        public int ColorId { get; set; }
        public virtual Colors? Color { get; set; }
        public virtual List<Booking>? Bookings { get; set;}
    }
}
