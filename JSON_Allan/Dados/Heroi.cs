using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Allan.Dados
{
    public class Heroi
    {

        public string Id { get; private set; }
        public string Nome { get; private set; }
        public double Idade {get; private set; }
        public string IdentidadeSecreta { get; private set; }
        public List<string> Poderes { get; private set; }
        
        public Heroi(string id, string nome, double idade, string identidadeSecreta, List<string> poderes) {
            this.Id = id;
            this.Nome = nome;
            this.Idade = idade;
            this.IdentidadeSecreta = identidadeSecreta;
            this.Poderes= poderes;
        }
    }
}
