using Features.OrderedEvents;
using UnityEngine;

namespace Features.Shop.UI
{
    public class ShopRerollButton : EventRaiserButton
    {
        public override void RaiseEvent()
        {
            Debug.Log("Rerolling shop");
            ShopEvents.OnShopReroll.Invoke();
        }
    }
}