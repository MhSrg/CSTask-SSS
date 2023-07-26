using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCollider : MonoBehaviour
{
    public SpriteRenderer z;
    public Image portrait;
    public bool firstZ;
    public bool firstConv;
    public bool kayLines;
    public bool manLines;
    public bool manLines2;
    public bool talkedToMan;
    public bool talkedToOldMan;
    public bool oldManLines;
    public bool oldManLines2;
    public bool receivedManGift;
    public bool receivedOldManGift;
    public bool manGiftLines;
    public Dialogue dialogueScript;
    public ShopManager shopManagerScript;

    public GameObject equipmentBigBox;

    private void Awake()
    {
        z.enabled = false;
        firstZ = false;
        firstConv = false;
        manLines = false;
        manLines2 = false;
        talkedToMan = false;
        talkedToOldMan = false;
        oldManLines2 = false;
        oldManLines = false;
        manGiftLines = false;
        receivedOldManGift = false;
        equipmentBigBox.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Shop")
        {
            z.enabled = true;
            firstZ = true;
            dialogueScript.lines = dialogueScript.linesSK;
            kayLines = true;
        }

        if (collision.gameObject.name == "Man_4" && talkedToMan == false)
        {
            manLines = true;
            dialogueScript.lines = dialogueScript.linesM4;
        }

        if (collision.gameObject.name == "OldMan_10" && talkedToOldMan == false)
        {
            oldManLines = true;
            dialogueScript.lines = dialogueScript.oldManLines;
        }

        if (collision.gameObject.name == "Cultist_1")
        {
            dialogueScript.lines = dialogueScript.cultistLines;
        }

        if (collision.gameObject.name == "Woman_10")
        {
            dialogueScript.lines = dialogueScript.roseLines;
        }

        if (collision.gameObject.name == "Man2_10")
        {
            dialogueScript.lines = dialogueScript.benjaminLines;
        }

        if (collision.gameObject.name == "Woman2_4")
        {
            dialogueScript.lines = dialogueScript.amandaLines;
        }

        if (collision.gameObject.name == "Door1")
        {
            dialogueScript.lines = dialogueScript.doorLines;
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Shop")
        {
            z.enabled = false;
            kayLines = false;
        }

        if (collision.gameObject.name == "Man_4" && talkedToMan == true && receivedManGift == false)
        {
            manLines = false;
            manLines2 = true;
            dialogueScript.lines = dialogueScript.manLines2;
            shopManagerScript.AddGold(7);
            receivedManGift = true;
        }

        if (collision.gameObject.name == "OldMan_10" && talkedToOldMan == true && receivedOldManGift == false)
        {
            oldManLines = false;
            oldManLines2 = true;
            dialogueScript.lines = dialogueScript.oldManLines2;
            shopManagerScript.AddGold(15);
            receivedOldManGift = true;
        }

        if (collision.gameObject.name == "Cultist_1")
        {
            shopManagerScript.AddGold(30);
            Destroy(collision.gameObject);
        }

        /*if (collision.gameObject.name == "Woman_10")
        {
            z.enabled = false;
            kayLines = false;
        }*/

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Shop" && Input.GetKeyDown(KeyCode.Z))
        {
            dialogueScript.gameObject.SetActive(true);
            dialogueScript.portraitPhoto.SetActive(true);
            portrait.sprite = Resources.Load<Sprite>("Portraits/Kay");
            dialogueScript.StartDialogue();
            shopManagerScript.chooseShop.SetActive(true);
        }

        if (collision.gameObject.name == "Man_4" && Input.GetKeyDown(KeyCode.Z))
        {
            dialogueScript.gameObject.SetActive(true);
            dialogueScript.portraitPhoto.SetActive(true);
            portrait.sprite = Resources.Load<Sprite>("Portraits/Guille");
            dialogueScript.StartDialogue();
            talkedToMan = true;
        }

        if (collision.gameObject.name == "OldMan_10" && Input.GetKeyDown(KeyCode.Z))
        {
            dialogueScript.gameObject.SetActive(true);
            dialogueScript.portraitPhoto.SetActive(true);
            portrait.sprite = Resources.Load<Sprite>("Portraits/Tristan");
            dialogueScript.StartDialogue();
            talkedToOldMan = true;
        }

        if (collision.gameObject.name == "Cultist_1" && Input.GetKeyDown(KeyCode.Z))
        {
            dialogueScript.gameObject.SetActive(true);
            dialogueScript.portraitPhoto.SetActive(true);
            portrait.sprite = Resources.Load<Sprite>("Portraits/Cultist");
            dialogueScript.StartDialogue();
        }

        if (collision.gameObject.name == "Woman_10" && Input.GetKeyDown(KeyCode.Z))
        {
            dialogueScript.gameObject.SetActive(true);
            dialogueScript.portraitPhoto.SetActive(true);
            portrait.sprite = Resources.Load<Sprite>("Portraits/Rose");
            dialogueScript.StartDialogue();
        }

        if (collision.gameObject.name == "Woman2_4" && Input.GetKeyDown(KeyCode.Z))
        {
            dialogueScript.gameObject.SetActive(true);
            dialogueScript.portraitPhoto.SetActive(true);
            portrait.sprite = Resources.Load<Sprite>("Portraits/Amanda");
            dialogueScript.StartDialogue();
        }

        if (collision.gameObject.name == "Man2_10" && Input.GetKeyDown(KeyCode.Z))
        {
            dialogueScript.gameObject.SetActive(true);
            dialogueScript.portraitPhoto.SetActive(true);
            portrait.sprite = Resources.Load<Sprite>("Portraits/Benjamin");
            dialogueScript.StartDialogue();
        }

        if (collision.gameObject.name == "Door1" && Input.GetKeyDown(KeyCode.Z))
        {
            dialogueScript.gameObject.SetActive(true);
            dialogueScript.StartDialogue();
        }
    }
}
