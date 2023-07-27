using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public CollisionCollider collisionColliderScript;
    public GameObject portraitPhoto;
    public GameObject z;
    public Movement movementScript;

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public string[] linesSK;
    public string[] linesSKT;
    public string[] linesM4;
    public string[] manLines2;
    public string[] oldManLines;
    public string[] oldManLines2;
    public string[] roseLines;
    public string[] benjaminLines;
    public string[] amandaLines;
    public string[] cultistLines;
    public string[] doorLines;
    public float textSpeed;

    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            z.SetActive(false);
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        index = 0;
        movementScript.enabled = false;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length -1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            portraitPhoto.SetActive(false);
            movementScript.enabled = true;
        }
    }
}
