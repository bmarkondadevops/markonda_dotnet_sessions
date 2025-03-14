﻿using System.ComponentModel.DataAnnotations;
using Bankpplication.Domain;

namespace Bankpplication.DTOs
{
    public class AccountMasterEditDto
    {

        public int Count { get; set; }
        public string HeaderTitle { get; set; } = "";
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Balance { get; set; }

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

    }
}