using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadecontatos
{
    internal class contato
    {
        // variáveis
        private string nome;
        private string sobrenome;
        private string telefone;

        // propriedade são os métodos "get e "set"
        // get leitura
        // definição
        // é possível ser somente leitura ou somente definição

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;

            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }
            }

            }
            public contato()
     
        {
            Nome = "bruno";
            Sobrenome = "barbosa";
            Telefone = "(11) 302426-9295";  
        }
        public contato(string nome, string sobrenome, string telefone)
        {

        }
        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("({0}) {1} ", Nome, Sobrenome);
            saida += string.Format("({0}) {1}-{2}", Telefone.Substring(0,2), Telefone.Substring(3,5), Telefone.Substring(7,4));
            return saida;
        }

    }   
    }


