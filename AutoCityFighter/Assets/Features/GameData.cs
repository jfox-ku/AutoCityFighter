using System;
using UnityEngine;

namespace Features
{
    [Serializable]
    [CreateAssetMenu(menuName = "Game/GameData")]
    public class GameData : ScriptableObject
    {
        public int Round;
        public int Wins;
        public int Loses;
        public int Draws;
        public int ShopLevel;
        public int Gold;
        
        public void Reset()
        {
            Round = 0;
            Wins = 0;
            Loses = 0;
            Draws = 0;
            ShopLevel = 0;
            Gold = 0;
        }
    }
}