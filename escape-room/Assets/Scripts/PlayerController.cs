using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float speed = 3;

    private Vector2 direction;

    private Animator animator;

    private enum Moving
    {
        up = 0,
        down = 1,
        right = 2,
        left = 3,
        none = 4,
    }

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
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
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            animate(Moving.up);
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            animate(Moving.left);
            direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            animate(Moving.down);
            direction = Vector2.down;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            animate(Moving.right);
            direction = Vector2.right;
        }
        
        else
        {
            animate(Moving.none);
        }
        
    }

    private void animate(Moving moving) {
        if (moving == Moving.up)
        {
            animator.SetBool("moveUp", true);
            animator.SetBool("moveDown", false);
            animator.SetBool("moveRight", false);
            animator.SetBool("moveLeft", false);
            animator.SetBool("noMove", false);
            animator.SetBool("interact", false);
        }

        else if (moving == Moving.down)
        {
            animator.SetBool("moveDown", true);
            animator.SetBool("moveRight", false);
            animator.SetBool("moveLeft", false);
            animator.SetBool("noMove", false);
            animator.SetBool("moveUp", false);
            animator.SetBool("interact", false);
        }
        else if (moving == Moving.left)
        {
            animator.SetBool("moveLeft", true);
            animator.SetBool("moveDown", false);
            animator.SetBool("moveRight", false);
            animator.SetBool("noMove", false);
            animator.SetBool("moveUp", false);
            animator.SetBool("interact", false);
        }
        else if (moving == Moving.right)
        {
            animator.SetBool("moveRight", true);
            animator.SetBool("moveDown", false);
            animator.SetBool("moveLeft", false);
            animator.SetBool("noMove", false);
            animator.SetBool("moveUp", false);
            animator.SetBool("interact", false);
        }
        
        else
        {
            animator.SetBool("noMove", true);
            animator.SetBool("moveDown", false);
            animator.SetBool("moveRight", false);
            animator.SetBool("moveLeft", false);
            animator.SetBool("moveUp", false);
            if (Input.GetKey(KeyCode.Space))
            {
                animator.SetBool("interact", true);
            }
            else
            {
                animator.SetBool("interact", false);
            }
        }
    }

}
