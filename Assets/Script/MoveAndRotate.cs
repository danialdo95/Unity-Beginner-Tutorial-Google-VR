using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndRotate : MonoBehaviour {

    [SerializeField]
    float speed = 0.25f;
    [SerializeField]
    float scale = 1;

	// Use this for initialization
	void Start () {

        //Debug.Log(transform);

        Transform myTransform = this.transform;
        Debug.Log(myTransform.position);
		
	}
	
	// Update is called once per frame
	void Update () {

        speed = Time.deltaTime;
        //DeltaTime betweeen call on update
        Move();
        Rotate();
        //Scale();

        scale = scale + 0.05f;
	}

    public void Move()
    {

        Vector3 movementVector = new Vector3(1.0f, 0.5f, 1.5f) * speed;
        transform.Translate(movementVector);
    }

    public void Rotate()
    {
        Vector3 rotationVector = new Vector3(1.0f, 0.0f, 0.0f);
        transform.Rotate(rotationVector);

    }

    public void Scale()
    {
        transform.localScale = new Vector3(scale, scale, scale);
    }


}
