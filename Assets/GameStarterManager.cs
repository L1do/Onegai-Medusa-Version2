using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarterManager : MonoBehaviour {


	//GameObject SpeedManager;

	// Use this for initialization
	void Awake (){

	//	SpeedManager = GameObject.FindGameObjectWithTag("SpeedManager");
	}
	void Start () {

//		SpeedManager.gameObject.SetActive(false);		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
    {
		  
		Debug.Log ("Start Game");
//		SpeedManager.gameObject.SetActive(true);	
			
		           
    }


}
