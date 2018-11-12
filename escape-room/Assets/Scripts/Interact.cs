using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

    private bool playerinside = false;
    DialogueTrigger dialogueTrigger;

    void Start()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            playerinside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            playerinside = false;
        }
    }
    private bool isInteractedWith()
    {
        return playerinside && Input.GetKeyUp(KeyCode.Space);
    }

    private void FixedUpdate()
    {
        if (isInteractedWith())
        {
            //Trigger a change in the dialogue box
            dialogueTrigger.TriggerDialogue();
        }   
    }

}
