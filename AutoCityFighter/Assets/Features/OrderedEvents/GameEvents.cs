namespace Features.OrderedEvents
{
    public static class GameEvents
    {
        public static OrderedVoidEvent OnGameStart = new OrderedVoidEvent();
        public static OrderedVoidEvent OnGameEnd = new OrderedVoidEvent();
    }
}