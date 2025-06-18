using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private UI_Bag uiBag;
    private Bag bag;
    void Start()
    {
        uiBag.SetBag(bag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
