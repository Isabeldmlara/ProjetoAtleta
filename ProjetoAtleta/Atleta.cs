using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura;
        private double peso;
        private int idade;

        public string Nome {
        get => nome;
            set
            {
                if(value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("Nome incorreto");
                }
            }
        }

        public double Altura { 
        get => altura;
            set
            {
                if(value != 0)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("Altura incorreta");
                }
            } 
        }

        public double Peso {
        get => peso;
            set
            {
                if (value != 0)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("Peso incorreto");
                }
            }
        }

        public int Idade { 
        get => idade;
            set
            {
                if (value != 0)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("Idade incorreta");
                }
            }
        }

        public double CalcularIMC()
        {
            return this.peso / Math.Pow(this.altura, 2);
        }
    }
}
