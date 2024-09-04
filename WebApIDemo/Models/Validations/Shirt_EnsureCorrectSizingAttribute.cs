using System;
using System.ComponentModel.DataAnnotations;

namespace WebApIDemo.Models.Validations
{
	public class Shirt_EnsureCorrectSizingAttribute :ValidationAttribute
	{
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}

