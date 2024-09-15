using System;
using System.Collections.Generic;
using UnityEngine;

namespace Features.Shop
{
    [CreateAssetMenu(menuName = "Shop/ShopLogic")]
    public class ShopLogic : ScriptableObject
    {
        public ShopConfig ShopConfig;
        public GameData GameData;
        
        
        
    }

    [Serializable]
    public class ShopConfig
    {
        public int IncomePerRound = 10;
        public int BaseBuyCost = 3;
        public int BaseSellCost = 1;
        public int BaseRerollCost = 1;
        public List<int> LevelCosts;
        public ShopAssets ShopAssets;
    }
}