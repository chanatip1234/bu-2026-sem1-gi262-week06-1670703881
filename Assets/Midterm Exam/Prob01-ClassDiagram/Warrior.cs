using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Warrior : Hero
    {
        public int ShildDefense = 20;
        private float rage = 2.0f;

        public override void Attack(GameEntity target)
        {
            Debug.Log("Warrior attacks with a mighty strike!");
        }

        public void ShildBash()
        {
            Debug.Log("Warrior performs a shield bash!");
        }
    }
}
