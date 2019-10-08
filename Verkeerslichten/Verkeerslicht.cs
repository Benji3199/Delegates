using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkeerslichten
{
    public enum LichtKleur { Groen, Rood };
    public class Verkeerslicht
    {
       public int Id { get; private set; }
        public string[] Reclame = { "Groene reclame is geblokeerd?", "Das es Rot" };
        public LichtKleur Kleur;

        public Verkeerslicht(int id, LichtKleur kleur)
        {
            Id = id;
            Kleur = kleur;
        }

        public void SwitchLicht()
        {
            if (Kleur == LichtKleur.Rood)
            {
                Kleur = LichtKleur.Groen;
            }
            else
            {
                Kleur = LichtKleur.Rood;
            }
        }

        public override string ToString()
        {
            return $"id: {Id}, kleur: {Kleur}, reclame: { Reclame[(int)Kleur]}";
        }
    }
}
