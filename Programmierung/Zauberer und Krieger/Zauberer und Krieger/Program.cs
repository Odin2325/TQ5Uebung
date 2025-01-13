using Assimp;
using Zauberer_und_Krieger.charaktere;
using Zauberer_und_Krieger.utils;

namespace Zauberer_und_Krieger
{
    internal class Program
    {
        private static Nachichten nachichten = new Nachichten();
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
        }
    }
}
