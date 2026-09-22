using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Equipment : InventoryItem
    {
        public int durability = 100;
        protected bool isEquipped = false;


        public virtual void Equip(Hero hero)
        {
            isEquipped = true;
            Debug.Log($"Equipment equipped! Durability: {durability}, Is Equipped: {isEquipped}");
        }

        public override void UseItem()
        {
            base.UseItem();
            Debug.Log($"Equipment used! Durability: {durability}");
        }
    }
}
