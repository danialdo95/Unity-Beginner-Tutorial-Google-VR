using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportingTheNumber : MonoBehaviour {

    public int TakenInteger;

	// Use this for initialization
	void Start () {
        TakenInteger = StaticScript.TheInteger;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
