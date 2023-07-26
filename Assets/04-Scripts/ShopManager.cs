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
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] myPurchaseButtons;

    public Dialogue dialogueScript;

    public GameObject chooseShop;
    public GameObject buyShop;

    void Start()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanelsGO[i].SetActive(true);
        }
        goldUI.text = gold.ToString();
        LoadItems();
        CheckPurchaseable();

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

    public void PurchaseItem(int btnNo)
    {
        if (gold >= shopItems[btnNo].value)
        {
            gold = gold - shopItems[btnNo].value;
            goldUI.text = gold.ToString();
            CheckPurchaseable();
        }
    }

    public void AddGold()
    {
        goldUI.text = gold.ToString();
        CheckPurchaseable();
    }

    public void LoadItems()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].titleTxt.text = shopItems[i].itemName;
            shopPanels[i].priceTxt.text = shopItems[i].value.ToString();
        }
    }

    public void CheckPurchaseable()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            if (gold >= shopItems[i].value)
            {
                myPurchaseButtons[i].interactable = true;
            }
            else
            {
                myPurchaseButtons[i].interactable = false;
            }
        }
    }
}
