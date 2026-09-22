using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Hero : Character
    {
        public int CurrentExp { get; private set; }
        private int gold = 0;

        public override void Attack(GameEntity target)
        {
            base.Attack(target);
            Debug.Log($"Hero attacks {target.id}!");
        }

        public void collectGold(int amount)
        {
            gold += amount;
            Debug.Log($"Hero collected {amount} gold! Total gold is now {gold}.");
        }

        protected override void LevelUp()
        {
            base.LevelUp();
        }

    }
}
