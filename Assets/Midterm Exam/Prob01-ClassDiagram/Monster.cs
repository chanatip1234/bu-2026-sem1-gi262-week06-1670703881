using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Monster : Character
    {
        public int baseDamage = 10;
        protected int aggroRange = 5;

        public override void Attack(GameEntity target)
        {
            base.Attack(target);
        }

        protected virtual void Roar()
        {
            Debug.Log("Monster roars to intimidate its enemies!");
        }
    }
}
