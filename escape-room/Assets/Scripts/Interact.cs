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

    private bool isDoor()
    {
        return gameObject.name.Equals("Door");
    }

    private void FixedUpdate()
    {
        if (isInteractedWith())
        {
            //Trigger a change in the dialogue box
            dialogueTrigger.TriggerDialogue();
            // if the door is interacted with, make the input box appear
            KeypadScript keyscript = FindObjectOfType<KeypadScript>();
            if (isDoor())
            {   
                keyscript.returnField();
            }
            else
            {
                keyscript.removeField();
            }
        }   
        
    }

}
