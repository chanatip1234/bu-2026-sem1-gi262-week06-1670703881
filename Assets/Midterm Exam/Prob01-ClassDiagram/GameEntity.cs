using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        public string id = ("PlayerID");
        private Vector3 position = new(1,0,0);
        protected int health = 100;
        public virtual void Update()
        {

        }

        public virtual void Takedamge(int damage)
        {
            
        }

        protected void Move(Vector3 direction)
        {
                
        }

    }
}
    

