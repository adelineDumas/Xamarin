using System;
namespace ProjetIncident.Core.DTO
{
    public class DescriptionIncident
    {
        public String Titre { get; set; }
        public String Description { get; set;  }


        public DescriptionIncident()
        {
            
        }

        public DescriptionIncident(string pTitre, string pDescription){
            this.Description = pDescription;
            this.Titre = pTitre; 
        }

        public override string ToString(){
            return Titre + " - " + Description; 
        }
    }
}

