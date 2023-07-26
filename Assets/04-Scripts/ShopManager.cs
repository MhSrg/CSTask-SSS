using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int gold;
    public TMP_Text goldUI;
    public SO_Items[] shopItems;
    public ShopTemplate[] shopPanels;

    public Dialogue dialogueScript;

    public GameObject chooseShop;
    public GameObject buyShop;

    void Start()
    {
        goldUI.text = gold.ToString();
        LoadItems();

        chooseShop.SetActive(false);
        buyShop.SetActive(false);
    }

    void Update()
    {
        
    }

    public void Buy()
    {
        buyShop.SetActive(true);
    }

    public void AddGold()
    {
        goldUI.text = gold.ToString();
    }

    public void LoadItems()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].titleTxt.text = shopItems[i].itemName;
            shopPanels[i].priceTxt.text = shopItems[i].value.ToString();
        }
    }
}
