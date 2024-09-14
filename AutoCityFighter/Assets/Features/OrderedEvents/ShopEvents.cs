namespace Features.OrderedEvents
{
    public static class ShopEvents
    {
        public static OrderedVoidEvent OnShopOpen = new OrderedVoidEvent();
        public static OrderedVoidEvent OnShopDone = new OrderedVoidEvent();
        public static OrderedVoidEvent OnShopReroll = new OrderedVoidEvent();
        public static OrderedEvent<BuyEvent> OnShopBuy = new OrderedEvent<BuyEvent>();
        public static OrderedEvent<SellEvent> OnShopSell = new OrderedEvent<SellEvent>();
        public static OrderedEvent<ShopLevelEvent> OnShopLevel = new OrderedEvent<ShopLevelEvent>();
    }
    
    public struct ShopLevelEvent
    {
        public int Level;
        public int Value;
    }
    
    public struct BuyEvent
    {
        public int ItemIndex;
        public int Value;
    }
    
    public struct SellEvent
    {
        public int ItemIndex;
        public int Value;
    }
    
}