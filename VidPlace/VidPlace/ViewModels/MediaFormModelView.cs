using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidPlace.Models;

namespace VidPlace.ViewModels
{
    public class MediaFormModelView
    {
       public Media media { get; set; }
       public List<MediaType> MediaTypeList { get; set; }
       public List<Genre> GenreList { get; set; }
    }
}