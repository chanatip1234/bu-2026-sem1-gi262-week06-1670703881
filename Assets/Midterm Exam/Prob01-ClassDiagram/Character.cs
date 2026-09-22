using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Character : GameEntity
    {
        public string CharacterName = "PlayerName";
        protected float movespeed = 5.0f;
        private int level = 10;


        public virtual void Attack(GameEntity target)
        {
            Debug.Log("Character is attacking!");
        }
        
        protected virtual void LevelUp()
        {
            level++;
            Debug.Log($"Character leveled up! New level: {level}");
        }
       
    }
}
