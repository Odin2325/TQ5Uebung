using System.Numerics;
using System.Reflection;
using System.Text;

namespace ProgrammierenLernen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FBKonto fBKonto = new FBKonto("max.mustermann@gmail.com","Musterstrasse 10","Max Mustermann","08248434345","maxie99","MaxMax");

            fBKonto.DetailsAnzeigen();

            fBKonto.FreundeHinzufuegen(new FBKonto("rosa.rosalie@outlook.com","Rosie Strasse 3","Rosa Rosalie","08347636238","sonnenschein123!@#$%^&*Rosa","Rosie1"));

            fBKonto.DetailsAnzeigen();
        }

    }

}
