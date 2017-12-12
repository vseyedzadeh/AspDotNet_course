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

        [Required(ErrorMessage = "Please enter the customer's Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(255, ErrorMessage = "Address can not be more than 255 character")]
        public string Address { get; set; }

        public Boolean IsSubscribedToNewsLetter { get; set; }
        
        [Display(Name = "Date of Birth")]
        [Min18YearsIfMember]//custom annotation that will be checked only in server side
        public DateTime? BirthDate { get; set; }

        [ForeignKey("MembershipTypeId")]
        public MembershipType MembershipType { get; set; }//make foreign key

        [Display(Name = "Membership Type")]//To display labal in form Instead of MembershipTypeId it shows Membership Type
        public int MembershipTypeId { get; set; }//to define the column for foreign key

        public List<Rental> Rentals { get; set; }


        //override tostring method
        public override string ToString()
        {
            return "Customer name: " + Name + "| Address:" + Address;
        }
    }

    
    

}