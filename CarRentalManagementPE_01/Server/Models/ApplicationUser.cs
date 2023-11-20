﻿using Microsoft.AspNetCore.Identity;

namespace CarRentalManagementPE_01.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}