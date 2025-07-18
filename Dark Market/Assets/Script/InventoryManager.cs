using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addItem(string itemName, int quantity, Sprite itemSprite)
    {
        Debug.Log("item Name = " + itemName + "Quantity = " + quantity + "itemSprite = " + itemSprite);
    }
}
