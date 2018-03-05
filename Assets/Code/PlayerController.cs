using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    // movement target
    public Transform target;

    //speed
    public float speed = 1;

    // flag that sets whether we are moving or not
    bool isMoving = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        HandleInput();

        HandleMovement();
    }

    void HandleInput()
    {
        //check for Fire1 Axis
        if (Input.GetButtonDown("Fire1"))
        {
            // negate isMoving
            isMoving = !isMoving;
        }

    }

    void HandleMovement()
    {

        // if we are not moving, exit
        if (!isMoving) return;

        // calculate the distance from the target
        float distance = Vector3.Distance(transform.position, target.position);
        // have we arrive?
        if (distance > 0)
        {
            // calculate how much we need to move (step) d = v* t
            float step = speed * Time.deltaTime;
            // move by that step
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);


        }
    }
}
