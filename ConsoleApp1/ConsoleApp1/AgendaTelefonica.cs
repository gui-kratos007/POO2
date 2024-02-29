using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AgendaTelefonica
    {
        public string proprietario { get; set; }
        public List<Contato> contatos { get; set; }


            public AgendaTelefonica(string proprietario)
        {
            this.proprietario = proprietario;
            contatos = new List<Contato>();
        }


        public void inserir(string nome, string numero)
        {
            contatos.Add(new Contato(nome, numero));
        }


        public void remover(string nome)
        {
            Contato c = buscar(nome);
            if (contatos.Remove(c))
            {
                Console.WriteLine("Não existe esse contato. ");
            }
        }


        public Contato buscar(string nome)
        {
            foreach (Contato c in contatos)
            {
                if (c.Nome.Contains(nome))
                {
                    return c;
                }
            }
            return null;
        }

        public int tamanho()
        {
            return contatos.Count;
        }
    }
}
