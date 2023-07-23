using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCollider : MonoBehaviour
{
    public SpriteRenderer z;

    private void Awake()
    {
        z.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "2B" || collision.gameObject.name == "desk")
        {
            z.enabled = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "2B" || collision.gameObject.name == "desk")
        {
            z.enabled = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {

        }
    }
}
