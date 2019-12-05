﻿using System;

namespace lib_funEnBulles
{
    public class Ouvrage
    {
        #region Proprieter
        private String isbn;
        private String titre;
        private int numTome;
        private String resume;
        private String format;
        private String image;
        private int nbPage;
        private DateTime dateParution;
        private DateTime dateCreation;
        private String categorie;
        private String genre;
        private double prixUnitaire;
        #endregion

        #region Constructeur
        public Ouvrage(String _isbn, string _titre, int _numTome, String _resume, String _format, String _image, int _nbPage, DateTime _dateParution, DateTime _dateCreation, String _categorie, String _genre, double _prixUnitaire)
        {
            Isbn = _isbn;
            Titre = _titre;
            NumTome = _numTome;
            Resume = _resume;
            Format = _format;
            Image = _image;
            NbPage = _nbPage;
            DateParution = _dateParution;
            DateCreation = _dateCreation;
            Categorie = _categorie;
            Genre = _genre;
            PrixUnitaire = _prixUnitaire;

        }
        #endregion


        public string Isbn { get => isbn; set => isbn = value; }
        public string Titre { get => titre; set => titre = value; }
        public int NumTome { get => numTome; set => numTome = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Format { get => format; set => format = value; }
        public string Image { get => image; set => image = value; }
        public int NbPage { get => nbPage; set => nbPage = value; }
        public DateTime DateParution { get => dateParution; set => dateParution = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Genre { get => genre; set => genre = value; }
        public double PrixUnitaire { get => prixUnitaire; set => prixUnitaire = value; }






    }
    
}
