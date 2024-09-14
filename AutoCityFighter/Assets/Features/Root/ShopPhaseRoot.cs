using UnityEngine;

namespace Features.Root
{
    public class ShopPhaseRoot : MonoBehaviour
    {
        public static ShopPhaseRoot Instance { get; private set; }
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(this);
            }
        }
        
        
    }
}