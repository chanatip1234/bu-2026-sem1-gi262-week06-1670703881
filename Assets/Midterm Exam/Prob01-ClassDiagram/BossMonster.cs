using UnityEngine;

namespace MidtermExam.Prob01
{
    public class BossMonster : Monster
    {
        public int phase = 1;
        private bool isEnraged = false;

        public override void Attack(GameEntity target)
        {
            base.Attack(target);
        }

        protected override void Roar()
        {
            base.Roar();
            Debug.Log("BossMonster roars with a terrifying presence!");
        }

        public void triggerphasetransition()
        {
            phase++;
            isEnraged = true;
            Debug.Log($"BossMonster has transitioned to phase {phase} and is now enraged!");
        }
    }
}
