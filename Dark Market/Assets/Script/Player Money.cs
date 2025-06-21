using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public int money;
    void Start()
    {

        money = 4;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
    }

    public void subtractMoney(int moneyToRemove)
    {
        if (money - moneyToRemove < 0)
        {
            Debug.Log("No money :(");
        }
        else { 
            money -= moneyToRemove; 
        }
            
    }
}
