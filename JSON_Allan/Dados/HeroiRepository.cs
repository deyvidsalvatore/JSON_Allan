using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Allan.Dados
{
    public class HeroiRepository
    {
        public static List<Heroi> Herois { get; private set; }

        public static void InitializeRepository()
        {
            Herois = new List<Heroi>();
        }

        // Adicionar herói
        public static void AddHeroi(Heroi heroi)
        {
            Herois.Add(heroi);
        }

        public static void DeleteHeroi(string id) {
            Herois.RemoveAll(e => e.Id.Equals(id));
        }

        public static void UpdateHeroi(string idHeroiOriginal, Heroi heroiAtualizado)
        {
            int indexHeroiOriginal = Herois.FindIndex(e => e.Id == idHeroiOriginal);

            if(indexHeroiOriginal != -1)
            {
                Herois[indexHeroiOriginal] = heroiAtualizado;
            }
        }
    }
}
