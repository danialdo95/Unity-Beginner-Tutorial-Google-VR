using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticScript : MonoBehaviour {

    public static int TheInteger = 3;
    public int InternalInteger;

	// Use this for initialization
	void Start () {
        InternalInteger = TheInteger;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
