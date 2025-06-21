using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public int money;
    public Text moneyText;
    void Start()
    {

        money = 4;
        moneyText.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addMoney(int moneyToAdd)
    {
        money += moneyToAdd;
        moneyText.text = money.ToString();
    }

    public void subtractMoney(int moneyToRemove)
    {
        if (money - moneyToRemove < 0)
        {
            Debug.Log("No money :(");
            moneyText.text = money.ToString();
        }
        else { 
            money -= moneyToRemove;
            moneyText.text = money.ToString();
        }
            
    }
}
