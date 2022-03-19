﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class AspNetUserClaims
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid? UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public AspNetUsers AspNetUsers { get; set; }
    }
}