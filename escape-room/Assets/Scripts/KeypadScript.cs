using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadScript : MonoBehaviour {

    private string answer = "ENIGMA";
    public InputField guess;

	// Use this for initialization
	void Start () {
        removeField();
	}

    public void removeField()
    {
        guess.gameObject.SetActive(false);
    }

    public void returnField()
    {
        guess.text = "";
        guess.gameObject.SetActive(true);
    }
	
    public bool isRight()
    {
        return (guess.text.ToUpper().Equals(answer));
    }

    public void verifyAnswer()
    {
        if (guess.IsActive() && isRight()) {
            Debug.Log("Right answer");
        }
        else if (guess.IsActive())
        {   
            removeField();
            DialogueManager diagManager = FindObjectOfType<DialogueManager>();
            diagManager.addDoorFailureMessage();
            return;
        }
	}
}
