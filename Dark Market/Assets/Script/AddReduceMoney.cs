using UnityEngine;

public class AddReduceMoney : MonoBehaviour
{
    public GameObject cam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown ("Fire1")) {
            cam.GetComponent<PlayerMoney>().addMoney(4);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            cam.GetComponent<PlayerMoney>().subtractMoney(31);
        }
    }
}
