﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieRental.Models;

namespace MovieRental.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
       
        public byte MembershipTypeId { get; set; }

       
       // [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }
    }
}