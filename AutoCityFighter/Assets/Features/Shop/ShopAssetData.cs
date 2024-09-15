using UnityEngine;

namespace Features.Shop
{
    public class ShopAssetData : ScriptableObject
    {
        public string Name;
        public string Description;
        public Sprite Icon;
        public int Price;
        public int MinLevel;
    }
}