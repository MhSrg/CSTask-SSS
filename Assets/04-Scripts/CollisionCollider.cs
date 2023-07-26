using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCollider : MonoBehaviour
{
    public SpriteRenderer z;
    public bool firstZ;
    public bool firstConv;
    public Dialogue dialogueScript;

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
        if (collision.gameObject.name == "Shop" && firstZ == false)
        {
            z.enabled = true;
            firstZ = true;
            dialogueScript.lines = dialogueScript.linesSK;

            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("me imagino que llega acá");
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Shop")
        {
            z.enabled = false;
        }
    }
}
