using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMoveTo : MonoBehaviour {

    public Transform HorseTarget;
    public PicupScript pc;
    public GameObject cube;
    private void Start()
    {
        pc = cube.GetComponent<PicupScript>();
    }

    // Update is called once per frame
    void FixedUpdate () {
      //  gameObject.transform.position = Vector3.MoveTowards(transform.position, HorseTarget.position, 0.08f);
    }
}
