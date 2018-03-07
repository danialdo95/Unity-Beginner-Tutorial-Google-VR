using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Decendify : MonoBehaviour {


    // public Animator Anime;
    public float MyTime = 0f;
    public Transform RadialProgress;

    // Use this for initialization
    void Start()
    {

        // Anime = GetComponent<Animator>();
        RadialProgress.GetComponent<Image>().fillAmount = MyTime;


    }

    // Update is called once per frame
    public void Update()
    {

        MyTime += Time.deltaTime;
        RadialProgress.GetComponent<Image>().fillAmount = MyTime;

        if (MyTime >= 3f)
        {

            teleporttotree();
        }


    }

    public void Resetinator()
    {
        MyTime = 0f;
        RadialProgress.GetComponent<Image>().fillAmount = MyTime;
    }


    public void teleporttotree()
    {

        gameObject.transform.position = new Vector3( 0, 4.37f, -10.98f);

    }

}
