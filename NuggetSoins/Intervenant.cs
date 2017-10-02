//-----------------------------------------------------------------------
// <copyright file="Intervenant.cs" company="BTS-SIO Lycée Bonaparte">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace NuggetSoins
{
    /// <summary>
    /// La classe Intervenant sert à instancier un Objet intervenant
    /// </summary>
    public class Intervenant
    {
        /// <summary>
        /// attribut unNom
        /// </summary>
        private string nom;

        /// <summary>
        /// attribut prenom
        /// </summary>
        private string prenom;

        /// <summary>
        /// attribut les prestations
        /// </summary>
        private List<Prestation> lesPrestations;



        /// <summary>

        /// Constructeur Initial

        /// </summary>

        /// <param name="unNom"></param>

        /// <param name="prenom"></param>

        /// <param name="lesPrestations"></param>

        /// 

        public Intervenant(string unNom, string prenom, List<Prestation> lesPrestations)

        {

            this.nom = unNom;

            this.prenom = prenom;

            this.lesPrestations = lesPrestations;

        }



        /// <summary>

        /// Surcharge du constructeur pour avoir seulement le unNom et le prénom de l'intervenant.

        /// </summary>

        /// <param name="nom"></param>

        /// <param name="prenom"></param>

        /// 

        public Intervenant(string nom, string prenom)

        {

            this.nom = nom;

            this.prenom = prenom;



        }



        public string Nom { get => nom; }

        public string Prenom { get => prenom; }

        public List<Prestation> LesPrestations { get => lesPrestations; }



        public void ajoutePrestation(Prestation unePrestation)

        {



            //lesPrestations.Add(unePrestation);

        }
    }

    }
