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
        private string _Mot_de_passe;
        private string _Droit;
        private DateTime _DateNaissance;

        public string Matricule { get => _Matricule; set => _Matricule = value; }
        public string Nom { get => _Nom; set => _Nom = value; }
        public string Prenom { get => _Prenom; set => _Prenom = value; }
        public string Ville { get => _Ville; set => _Ville = value; }
        public string CodePostal { get => _CodePostal; set => _CodePostal = value; }
        public string Adresse { get => _Adresse; set => _Adresse = value; }
        public string Telephone { get => _Telephone; set => _Telephone = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Pseudo { get => _Pseudo; set => _Pseudo = value; }
        public string Mot_de_passe { get => _Mot_de_passe; set => _Mot_de_passe = value; }
        public string Droit { get => _Droit; set => _Droit = value; }
        public DateTime DateNaissance { get => _DateNaissance; set => _DateNaissance = value; }
    }
}
