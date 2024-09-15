using System;
using System.Collections.Generic;
using UnityEngine;

namespace Features.Shop.UI
{
    public class ShopBuyBar : MonoBehaviour
    {
        public List<ShopBuyButton> BuyButtons;

        private void Awake()
        {
            foreach (var buyButton in BuyButtons)
            {
                buyButton.Button.onClick.AddListener(() => Buy(buyButton));
            }
        }
    }
}