using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {

    public Transform Position1, Position2;
    private bool myBool = false;
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!myBool)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, Position2.position, 0.008f);
            if(transform.position == Position2.position)
            {
                myBool = true;
            }
        }
        else
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, Position1.position, 0.008f);
            if (transform.position == Position1.position)
            {
                myBool = false;
            }
        }

	}
}
