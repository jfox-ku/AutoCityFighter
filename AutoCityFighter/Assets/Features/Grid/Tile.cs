using System;
using System.Collections.Generic;
using UnityEngine;

namespace Features.Grid
{
    [Serializable]
    public class Tile : IGridElement
    {
        public Vector2Int Position { get; set; }
        public List<TileComponent> Components = new List<TileComponent>();
        
        public void AddComponent(TileComponent component)
        {
            if(Components.Contains(component) == true) return;
            Components.Add(component);
        }
        
        public void RemoveComponent(TileComponent component)
        {
            if(Components.Contains(component) == false) return;
            Components.Remove(component);
        }
        
        public bool HasComponent<T>() where T : TileComponent
        {
            return Components.Exists(c => c.GetType() == typeof(T));
        }
        
        public T GetComponent<T>() where T : TileComponent
        {
            return (T)Components.Find(c => c.GetType() == typeof(T));
        }
    }
}