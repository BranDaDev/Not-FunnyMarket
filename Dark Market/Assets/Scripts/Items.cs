using UnityEngine;

public class Items 
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public enum ItemType
    {
        IceCream, 
        WaterGun,
        Jug,
        Shovel,
        ChildTears,
        
    }
    public ItemType itemType;
    public int amount; 
}
