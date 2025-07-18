using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    [SerializeField]
    private string itemName;

    [SerializeField]
    private int quantity;

    [SerializeField]
    private Sprite sprite;

    private InventoryManager InventoryManager;
    void Start()
    {
       InventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>(); 
    }

        public void getItem(Items item)
    {
        InventoryManager.addItem(itemName, quantity, sprite);
    }
    // Update is called once per frame
  
}
