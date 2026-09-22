using Unity.VisualScripting;
using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Weapon
    {
        public int extraDamage = 35;
        private float criticalChance = 0.15f;

        public void EquipWeapon(Hero hero)
        {
            Debug.Log($"Weapon equipped! Extra damage is {extraDamage} and critical chance is {criticalChance * 100}%.");
        }

        public void Polish()
        {
            Debug.Log("Weapon polished! Critical chance increased.");
            criticalChance += 0.05f; // Increase critical chance by 5%
        }
    }
}
