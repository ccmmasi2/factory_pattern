using Pattern.Factory.Core.Models;

namespace Pattern.Factory.Core
{
    public class GameLogic
    {
        public GameLogic() 
        {
            BaseEnemy baseEnemy = FactoryClass.CreateEnemy(FactoryClass.Alien);
            Console.WriteLine(baseEnemy.DamagePower());
        }

        public void GameLogicFunction(List<BaseEnemy> LEnemies)
        {
            foreach (var item in LEnemies)
            {
                item.DamagePower();
            }
        }
    }
}
