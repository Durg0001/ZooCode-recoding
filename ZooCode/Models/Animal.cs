// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooCode.Models
{   
    public class Animal
    {        
        public int AnimalID { get; set; }
        
        [StringLength(50)]
        [Display(Name = "Dyr")]
        [Required(ErrorMessage = "Skrive venligst et navn på dyr type")]     
        public string Animal_name { get; set; }        
        public virtual ICollection<ZooAnimal> ZooAnimalCollection { get; set; }
    }
}