using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VidPlace.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Address { get; set; }

        public Boolean IsSubscribedToNewsLetter { get; set; }
        
        public DateTime? BirthDate { get; set; }

        [ForeignKey("MembershipTypeId")]
        public MembershipType MembershipType { get; set; }//make foreign key

        [Display(Name = "Membership Type")]//To display labal in form Instead of MembershipTypeId it shows Membership Type
        public int MembershipTypeId { get; set; }//to define the column for foreign key



        //override tostring method
        public override string ToString()
        {
            return "Customer name: " + Name + "| Address:" + Address;
        }
    }

    
    

}