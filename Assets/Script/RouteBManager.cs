using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteBManager : MonoBehaviour {

	public GameObject RouteA;
	public GameObject RouteB;

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
		  
		Debug.Log ("Route B を選択しました ");
		Destroy(RouteA);
		           
    }
}
