using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace CarRentalManagementPE_01.Client.Pages.Static

{

    public static class Endpoints

    {

        public static readonly string Prefix = "api";

        public static readonly string MakesEndpoint = $"{Prefix}/makes";

        public static readonly string ModelsEndpoint = $"{Prefix}/models";

        public static readonly string ColoursEndpoint = $"{Prefix}/colors";

        public static readonly string VehiclesEndpoint = $"{Prefix}/vehicles";

        public static readonly string CustomersEndpoint = $"{Prefix}/customers";

        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";

    }

}
