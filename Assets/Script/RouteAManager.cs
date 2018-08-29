using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteAManager : MonoBehaviour {

	GameObject RouteA;
	GameObject RouteB;

	// Use this for initialization
	void Start () {
		
		RouteA = GameObject.FindGameObjectWithTag("RouteA");
		RouteB = GameObject.FindGameObjectWithTag("RouteB");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

		void OnTriggerEnter(Collider other)
    {
		  
		Debug.Log ("Route A を選択しました ");
		Destroy(RouteB);
		           
    }
}
