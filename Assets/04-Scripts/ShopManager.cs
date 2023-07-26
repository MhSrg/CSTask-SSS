using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public Dialogue dialogueScript;

    public GameObject chooseShop;
    public GameObject buyShop;

    void Start()
    {
        chooseShop.SetActive(false);
        buyShop.SetActive(false);
    }

    void Update()
    {
        
    }

    public void Buy()
    {
        //dialogueScript.gameObject.SetActive(false);
        //dialogueScript.portraitPhoto.gameObject.SetActive(false);
        buyShop.SetActive(true);
    }
}
