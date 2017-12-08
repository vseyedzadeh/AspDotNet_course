﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidPlace.Models
{
    public class Media
    {
        public int ID { get; set; }

        [Required][StringLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public int NumberInStock { get; set; }

        [Required]
        public MediaType MediaType { get; set; }
        public int MediaTypeID { get; set; }


        [Required]
        public Genre Genre { get; set; }
        public int GenreID { get; set; }


        //override tostring method
        public override string ToString()
        {
            return "Media name: " + Name ;
        }

    }
}