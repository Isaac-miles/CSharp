using System;
using System.ComponentModel.DataAnnotations;
using WebApIDemo.Models.Validations;

namespace WebApIDemo.Models
{
	public class Shirt
	{
		public int ShirtId { get; set; }

        [Required]
        public string? Color { get; set; }

        [Required]
		public string? Brand { get; set; }

        [Shirt_EnsureCorrectSizing]
        public int? Size { get; set; }

		public double? Price { get; set; }

        [Required]
        public string? Gender {get; set; }
    }
}

