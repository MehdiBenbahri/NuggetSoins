//-----------------------------------------------------------------------
// <copyright file="Prestation.cs" company="BTS-SIO Lycée Bonaparte">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace NuggetSoins
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Classe pour les prestations
    /// </summary>
    public class Prestation
    {
        // Note: L'attribut heureSoin doit être de type heure,à voir si on ne peut pas faire avec 
        // La Structure DateTime...

        /// <summary>
        /// Nom de la prestation
        /// </summary>
        private string libelle;

        private int test;

        /// <summary>
        /// Date de soin,date de la prestion
        /// </summary>
        private DateTime dateSoin;

        /// <summary>
        /// L'objet intervenant qui concerne cette prestation
        /// </summary>
        private Intervenant leIntervenant;

        /// <summary>
        /// Constructeur de la classe Préstation
        /// </summary>
        /// <param name="lib"> paramètre pour avoir le libelle </param>
        /// <param name="dateSoin"> paramètre pour la date de la prestation </param>
        /// <param name="I_inter"> avoir le nom de l'intervenant </param>
        public Prestation(string lib, DateTime dateSoin, Intervenant I_inter)
        {
            this.libelle = lib;

            this.dateSoin = dateSoin;

            this.leIntervenant = I_inter;

            // La classe Prestation à la responsabilité d'instancier cette collection (voir Exo 2) 
            I_inter.ajoutePrestation(this);
        }

        /// <summary>
        /// getter pour libelle
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// getter pour dateSoin
        /// </summary>
        public DateTime DateSoin { get => dateSoin; set => dateSoin = value; }

        /// <summary>
        /// getter pour Intervenant
        /// </summary>
        public Intervenant I_Intervenant1 { get => leIntervenant; }

        /// <summary>
        /// Permet de comparer des date via la méthode Compare
        /// </summary>
        /// <param name="unePrestation"> pour avoir l'objet de la classe Prestation </param>
        /// <returns>retourne 0 si les date sont égaux,1 si la 2ème est postérieur,et -1 si la 2ème est inférieur</returns>
        public int CompareA(Prestation unePrestation)
        {
            int c = DateTime.Compare(this.dateSoin, unePrestation.DateSoin);

            return c;
        }
    }
}
