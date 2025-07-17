using UnityEditor.Rendering;
using UnityEngine;

public class AddReduceMoney : MonoBehaviour
{
    public GameObject cam;
 
    public void OnClickAdd()
    {
        cam.GetComponent<PlayerMoney>().addMoney(4);
    }

    public void OnClickSubtract()
    {
        cam.GetComponent<PlayerMoney>().subtractMoney(30);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
