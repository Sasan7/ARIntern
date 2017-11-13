using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject basket = GameObject.Find("Basket");
		if (basket)
			GetComponent<UnityEngine.AI.NavMeshAgent>().destination = basket.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
