using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement : MonoBehaviour {


    [SerializeField]
    string _movementX;

    [SerializeField]
    string _movementZ;

    [SerializeField]
    float _speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float moveX = Input.GetAxis(_movementX);
        float moveZ = Input.GetAxis(_movementZ);

        Vector3 moveVector = new Vector3(moveX, 0, moveZ) * (Time.deltaTime * _speed);

        this.transform.Translate(moveVector, Space.World);



	}
}
