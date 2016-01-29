using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.Puzzles.TowersOfHanoi
{
    public class TowersOfHanoi
    {
        public void Run()
        {
            MoveTower(4, "A", "C", "B");
        }

        public void MoveTower(int n, string fromTower, string toTower, string withTower)
        {
            if (n > 0)
            {
                MoveTower(n - 1, fromTower, withTower, toTower); //Ex: Reduce problem space. Ex: 4 is present, but create new problem with 321 moving to towerB; 
                Console.WriteLine(string.Format("Moving Disc {0} from Tower {1} to {2}.", n, fromTower, toTower));
                MoveTower(n - 1, withTower, toTower, fromTower); //Now, consider withTower as from tower ,since it now has 321.
            }
        }
    }
}
