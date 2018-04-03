using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetIncident.Core.Model
{

    public class User
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public String LastName { get; set; }

        public String FirstName { get; set; }

        public String Mail { get; set; }

        public String EncryptedPassword { get; set; }

        [InverseProperty(nameof(Incident.User))]
        public List<Incident> Incidents { get; set; }

        public User()
        {

        }

        public User(string pLastName, string pFirstName, string pMail, string pPassword){
            this.LastName = pLastName;
            this.FirstName = FirstName;
            this.Mail = pMail;
            this.EncryptedPassword = pPassword; 
        }
    }
}