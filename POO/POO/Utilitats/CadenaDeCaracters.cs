using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitats
{
    public class CadenaDeCaracters
    {
        #region atributs / camps
        char[] lletres; 
        bool esMotDePas;
        char caracterDelMotDePas;
        #endregion

        #region constructors

        public CadenaDeCaracters()
        {
            Console.WriteLine("Acabo de crear una cadena de caracters");
            lletres = new char[] { 'P', 'a', 't', 'a', 't', 'a' };
            esMotDePas = false;
            caracterDelMotDePas = '*';
        }

        public CadenaDeCaracters (char[] lletres, bool esMotDePas, char caracterDelMotDePas)
        {
            this.lletres = lletres;
            this.EsMotDePas = esMotDePas;
            this.caracterDelMotDePas = caracterDelMotDePas;
        }



        #endregion

        #region propietats

        //public bool GetEsMotDePas()
        //{
        //    return esMotDePas;
        //}

        //public void SetEsMotDePas(bool valor)
        //{
        //    esMotDePas = valor;
        //}

        public bool EsMotDePas
        {
            get //obtenir un valor
            {
                return esMotDePas;
            }

            set //asignar un valor
            {
                esMotDePas = value;
            }
        }
        /// <summary>
        /// Obten o estableix el caracter que es mostrara com mot de pas.
        /// </summary>
        public char CaracterDelMotDePas
        {
            get
            {
                return caracterDelMotDePas;
            }

            set
            {
                caracterDelMotDePas = value;
            }
        }

        #endregion

        #region Mètodes
        public void Escriu()
        {
            for (int posicio = 0; posicio < lletres.Length; posicio++)
            {
                if (EsMotDePas)
                {
                    Console.Write(caracterDelMotDePas);
                }

                else
                {
                    Console.Write(lletres[posicio]);
                }
            }
        }
        #endregion
    }
}
