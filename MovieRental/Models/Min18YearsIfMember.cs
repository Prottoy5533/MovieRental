﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieRental.Dtos;

namespace MovieRental.Models
{
    public class Min18YearsIfMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            if (customer.MembershipTypeId==0 || customer.MembershipTypeId == 1)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required");
            
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age > 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer need atleast 18 years to go on a membership");
        }
    }
}