using Pattern.Factory.Core.Models;
using Pattern.Factory.Core.Models.Enemies;

namespace Pattern.Factory.Core
{
    public class FactoryClass
    {
        public const int Lotso = 1;
        public const int Darth_Vader = 2;
        public const int Hans_Landa = 3;
        public const int Alien = 4;
        public const int Predator = 5;

        public static BaseEnemy CreateEnemy(int tipo)
        {
            switch (tipo)
            {
                case Lotso:
                    return new Lotso();
                case Darth_Vader:
                    return new Darth_Vader();
                case Hans_Landa:
                    return new Hans_Landa();
                case Alien: 
                    return new Alien(); 
                case Predator:
                    return new Predator();
                default: 
                    return new Lotso();
            }
        }
    }
}
