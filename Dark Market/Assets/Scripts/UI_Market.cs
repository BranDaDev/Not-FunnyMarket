using UnityEngine;
public class MArketScript : MonoBehaviour
{
    private Transform container;
    private Transform MarketItemTemplate;

    private void Awake()
    {
        container = transform.Find("container");
        MarketItemTemplate = transform.Find("MarketItemTemplate");
        MarketItemTemplate.gameObject.SetActive(false);
    }
    void Start()
    {
        createItemButton(Contex)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
