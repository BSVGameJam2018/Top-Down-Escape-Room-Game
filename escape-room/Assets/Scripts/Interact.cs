using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

    private bool playerinside = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Debug.Log("Entering...");
            playerinside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Debug.Log("Exiting...");
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
            //Run the method to interact with the object
            Debug.Log("INTERACTION!!!!!");
        }   
    }

}
