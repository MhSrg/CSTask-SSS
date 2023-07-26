using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int gold;
    public TMP_Text goldUI;
    public SO_BodyPart[] shopItems;
    public SO_BodyPart[] partsOwnedToSellList;
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

    public void Buy()
    {
        buyShop.SetActive(true);
    }

    public void PurchaseItem(int btnNo)
    {
        if (gold >= shopItems[btnNo].buyPrice)
        {
            Debug.Log("esto pasa?");
            gold = gold - shopItems[btnNo].buyPrice;
            goldUI.text = gold.ToString();
            CheckPurchaseable();
        }
    }

    public void SellItem(int btnNo)
    {
        gold = gold + partsOwnedToSellList[btnNo].sellPrice;
        goldUI.text = gold.ToString();
        shopPanels[btnNo].soldTxt.enabled = true;
        shopPanels[btnNo].priceTxt.enabled = false;
        shopPanels[btnNo].buyButton.enabled = false;
        /*List<SO_BodyPart> partsRemaining = new List<SO_BodyPart>();
        partsRemaining.Remove(partsRemaining[btnNo]);
        SO_BodyPart[] partsRemaining2 = partsRemaining.ToArray();*/
    }

    public void AddGold()
    {
        goldUI.text = gold.ToString();
        CheckPurchaseable();
        Debug.Log("se añadió oro");
    }

    public void LoadItems()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            shopPanels[i].titleTxt.text = shopItems[i].bodyPartName;
            shopPanels[i].spriteItem = shopItems[i].spriteOnShop;
            shopPanels[i].priceTxt.text = shopItems[i].buyPrice.ToString();
        }
    }

    public void CheckPurchaseable()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            if (gold >= shopItems[i].buyPrice)
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
