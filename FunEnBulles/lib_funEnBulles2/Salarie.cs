using lib_funEnBulles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_funEnBulles2
{
    public class Salarie : Utilisateur
    {
        private string _Grade;
        private DateTime _DateEmbauche;
        private string _Service;

        public Salarie(string matricule, string nom, string prenom, string ville, string codePostal, string adresse, string telephone, string email, string pseudo, string motDePasse, string droit, DateTime dateNaissance, string grade, DateTime dateEmbauche, string service)
        : base(matricule, nom, prenom, ville, codePostal, adresse, telephone, email, pseudo, dateNaissance)
        {
            _Grade = grade;
            _DateEmbauche = dateEmbauche;
            _Service = service;
        }

        public string Grade { get => _Grade; set => _Grade = value; }
        public DateTime DateEmbauche { get => _DateEmbauche; set => _DateEmbauche = value; }
        public string Service { get => _Service; set => _Service = value; }
    }
}
