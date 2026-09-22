using UnityEngine;

namespace MidtermExam.Prob01
{
    public class MinionMonster
    {
        public int swarmBonus = 5;
        private bool isAlert = false;   

        public void callReinforcements()
        {
            isAlert = true;
            Debug.Log($"MinionMonster calls for reinforcements! Swarm bonus is {swarmBonus} and alert state is {isAlert}.");
        }
    }
}
