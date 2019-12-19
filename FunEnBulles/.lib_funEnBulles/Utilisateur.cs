using System;
using System.Collections.Generic;
using System.Text;

namespace lib_funEnBulles
{
    public class Utilisateur
    {
        private string _Matricule;
        private string _Nom;
        private string _Prenom;
        private string _Ville;
        private string _CodePostal;
        private string _Adresse;
        private string _Telephone;
        private string _Email;
        private string _Pseudo;
        private string _Droit;
        private DateTime _DateNaissance;

        public Utilisateur(string matricule, string nom, string prenom, string ville, string codePostal, string adresse, string telephone, string email, string pseudo, string droit, DateTime dateNaissance)
        {
            _Matricule = matricule;
            _Nom = nom;
            _Prenom = prenom;
            _Ville = ville;
            _CodePostal = codePostal;
            _Adresse = adresse;
            _Telephone = telephone;
            _Email = email;
            _Pseudo = pseudo;
            _Droit = droit;
            _DateNaissance = dateNaissance;
        }

        public string Matricule { get => _Matricule; set => _Matricule = value; }
        public string Nom { get => _Nom; set => _Nom = value; }
        public string Prenom { get => _Prenom; set => _Prenom = value; }
        public string Ville { get => _Ville; set => _Ville = value; }
        public string CodePostal { get => _CodePostal; set => _CodePostal = value; }
        public string Adresse { get => _Adresse; set => _Adresse = value; }
        public string Telephone { get => _Telephone; set => _Telephone = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Pseudo { get => _Pseudo; set => _Pseudo = value; }
        public string Droit { get => _Droit; set => _Droit = value; }
        public DateTime DateNaissance { get => _DateNaissance; set => _DateNaissance = value; }
    }
}
