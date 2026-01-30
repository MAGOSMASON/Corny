using System;
using System.ComponentModel.DataAnnotations;

namespace CORNY.Models.Validation
{
    public class MinimumAgeAttribute : ValidationAttribute
    {
        private readonly int _minAge;

        public MinimumAgeAttribute(int minAge)
        {
            _minAge = minAge;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
                return ValidationResult.Success; // Let [Required] handle missing DOB

            if (value is not DateTime dob)
                return new ValidationResult("Invalid date.");

            var today = DateTime.Today;
            var age = today.Year - dob.Year;

            // If birthday hasn't happened yet this year, subtract 1
            if (dob.Date > today.AddYears(-age)) age--;

            return age >= _minAge
                ? ValidationResult.Success
                : new ValidationResult(ErrorMessage ?? $"You must be at least {_minAge} years old.");
        }
    }
}
