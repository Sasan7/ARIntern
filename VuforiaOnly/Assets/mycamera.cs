using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mycamera : MonoBehaviour {
    Vector3 rotationss = new Vector3(90f, 0, 0);
    public GameObject myCameraa;
    private Quaternion desiredRotation;
    private bool myCond;
    // Use this for initialization
    void Awake () {
        myCameraa = GameObject.FindGameObjectWithTag("MainCamera");
        Invoke("myroate", 0.4f);
	}

    // void Update()
    //{
    //    if (myCond)
    //    {
    //        if(desiredRotation != Quaternion.identity)
    //        {
    //            myCameraa.transform.Rotate(Vector3.left, -60f);
    //        }
    //    }
    //}

    void myroate()
    {
        myCameraa.transform.Rotate(Vector3.left, -60f);
        desiredRotation = Quaternion.identity;
        myCond = true;
        Debug.Log("ROtated");
    }

}
