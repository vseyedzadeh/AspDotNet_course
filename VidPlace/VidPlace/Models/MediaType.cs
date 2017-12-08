﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidPlace.Models
{
    public class MediaType
    {
        public int ID { get; set; }

        [Required][MaxLength(255)]
        public string TypeName { get; set; }
    }
}