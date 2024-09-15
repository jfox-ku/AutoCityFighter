using System.Collections.Generic;
using UnityEngine;

namespace Features.Shop
{
    [CreateAssetMenu(menuName = "Shop/ShopAssets")]
    public class ShopAssets : ScriptableObject
    {
        public List<ShopAssetData> DataList;
    }
}