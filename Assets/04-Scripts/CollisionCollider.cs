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
    public Dialogue dialogueScript;
    public ShopManager shopManagerScript;

    public GameObject equipmentBigBox;

    private void Awake()
    {
        z.enabled = false;
        firstZ = false;
        firstConv = false;
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
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Shop")
        {
            z.enabled = false;
            kayLines = false;
        }
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
    }
}
