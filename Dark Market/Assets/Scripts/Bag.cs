using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bag
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private List<Items> itemList;

    public Bag() {
        itemList = new List<Items>();
        Debug.Log("Bag");
        addItem(new Items { itemType = Items.ItemType.IceCream, amount = 1 });
    }    

    public void addItem(Items item)
    {
        itemList.Add(item);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
