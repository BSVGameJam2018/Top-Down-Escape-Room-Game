using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float speed = 3;

    private Vector2 direction;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
    // where most game code goes
	void Update () {
        GetInput();
        Move();
	}

    public void Move()
    {
        transform.Translate(direction*speed*Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.zero;

        //If you want to move in multiple directions (ex. up and right) add += instead of plus
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            direction = Vector2.up;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Button continueButton = GameObject.FindGameObjectWithTag("ContinueButton").GetComponent<Button>();
            continueButton.onClick.Invoke();
        }
    }

}
