using UnityEngine;

namespace MidtermExam.Prob01
{
    public class InventoryItem
    {
        public string itemName = "Sword";
        protected int weight = 20;
        private int itemvalue = 50;

        public virtual void UseItem()
        {
            Debug.Log($"Using {itemName}!");
        }
    }
}
