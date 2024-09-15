using TMPro;
using UnityEngine.UI;

namespace Features.Shop.UI
{
    public class ShopBuyButton : EventRaiserButton
    {
        public int BuyButtonIndex;
        public Image Icon;
        public TextMeshPro Name;

        public void Initialize(int index)
        {
            BuyButtonIndex = index;
        }

        public void SetAssetData(ShopAssetData data)
        {
            if (data == null)
            {
                SetEmpty();
                return;
            };
            
            Icon.sprite = data.Icon;
            Name.text = data.Name;
        }
        
        public void SetEmpty()
        {
            
        }

        public void SetClickable(bool isClickable)
        {
            Button.interactable = isClickable;
        }
        
        public override void RaiseEvent()
        {
            
        }
    }
}