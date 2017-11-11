using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsntantiateObjects : MonoBehaviour {

    public GameObject toBeInstantiated,ToBeInstantiated2;
    private bool instantiatedOne;
    public GameObject basket1, basket2;
    public Transform placeholder;
    private GameObject ball,ball2;
    
    void Start () {
        instantiatedOne = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("collided");
        if(col.gameObject.name == basket1.name && !instantiatedOne)
        {
            Debug.Log("Ball one instantiated");
            instantiatedOne = true;
            
            ball = Instantiate(toBeInstantiated, placeholder.transform.position, Quaternion.identity, placeholder);
        }
        if(col.gameObject.name == basket2.name && instantiatedOne)
        {
            if(ball != null)
            {
                Destroy(ball);
                ball = null;
                instantiatedOne = false;
                ball2 = Instantiate(ToBeInstantiated2, placeholder.transform.position, Quaternion.identity);
                Destroy(ball2, 2f);
            }
            else
            {
                Debug.Log("Hand is empty");
            }
        }
    }
}
