using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Mage : Character
    {
        public int mana = 100;
        private int spellPower = 50;

        public override void Attack(GameEntity target)
        {
            base.Attack(target);
            Debug.Log($"Mage attacks {target.id} with spell power {spellPower}!");
        }
        

        public void CastSpell()
            {
                if (mana >= 10)
                {
                    mana -= 10;
                    Debug.Log($"Mage casts a spell! Remaining mana: {mana}");
                }
                else
                {
                    Debug.Log("Not enough mana to cast a spell!");
                }
        }
    }
}
