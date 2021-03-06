﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NuggetSoins
{
    /// <summary>
    /// Classe héritiere de la classe Intervernant.
    /// </summary>
    public class IntervenantExterne : Intervenant

    {
        /// <summary>
        /// Attribut de la classe
        /// </summary>
        private string specialite;
        /// <summary>
        /// c'est l'adresse
        /// </summary>
        private string adresse;

        private string tel;

       


        /// <summary>

        /// Constructeur initial

        /// </summary>

        /// <param name="nom"></param>

        /// <param name="prenom"></param>

        /// <param name="lesPrestations"></param>

        /// <param name="specialite"></param>

        /// <param name="adresse"></param>

        /// <param name="tel"></param>

        /// 

        public IntervenantExterne(string nom, string prenom, List<Prestation> lesPrestations, string specialite, string adresse, string tel) : base(nom, prenom, lesPrestations)

        {

            this.specialite = specialite;

            this.adresse = adresse;

            this.tel = tel;

        }



        /// <summary>

        /// Surcharge du constructeur pour pouvoir utiliser la surcharge du constructeur de la classe mère

        /// </summary>

        /// <param name="nom"></param>

        /// <param name="prenom"></param>

        /// <param name="specialite"></param>

        /// <param name="adresse"></param>

        /// <param name="tel"></param>

        /// 

        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel) : base(nom, prenom)

        {

            this.specialite = specialite;

            this.adresse = adresse;

            this.tel = tel;

        }





        /// <summary>

        /// Get/Set

        /// </summary>

        /// 

        public string Specialite { get => specialite; }

        public string Adresse { get => adresse; }

        public string Tel { get => tel; }

    }
}
