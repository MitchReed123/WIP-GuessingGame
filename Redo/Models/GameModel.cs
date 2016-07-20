using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Redo.Models
{
    public class GameModel
    {
        [Display(Name = "Enter Your Name")]
        [Required(ErrorMessage = "You must enter your name")]
        [MinLength(1, ErrorMessage = " Name is too short")]
        [MaxLength(20, ErrorMessage = "Name is too long")]
        public string PlayerName { get; set; }

        [Display(Name = "What is your guess?")]
        [Required(ErrorMessage = "Guess is Required")]
        [Range(10, 50, ErrorMessage = "Guess Must be Between 10 and 50")]
        public int Guess { get; set; }

        public string HighLow { get; set; }

        public override string ToString()
        {
            return $"{PlayerName} ({Guess})";
        }
    }
}