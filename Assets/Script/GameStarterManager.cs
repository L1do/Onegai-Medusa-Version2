using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarterManager : MonoBehaviour {

	GameObject RightHand;
	GameObject LeftHand;
	GameObject SpeedManager;

	GameObject firstGear;

	GameObject zeroGear;


	// Use this for initialization
	void Awake ()
	{
		zeroGear = GameObject.FindGameObjectWithTag("ZeroGear");
		firstGear = GameObject.FindGameObjectWithTag("FirstGear");
		RightHand = GameObject.FindGameObjectWithTag("RightHand");
		LeftHand = GameObject.FindGameObjectWithTag("LeftHand");
	}
	void Start () {

			//firstGear.gameObject.SetActive(true);
			//zeroGear.gameObject.SetActive(false);	
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other)
    {
		firstGear.gameObject.SetActive(true);
		zeroGear.gameObject.SetActive(false);	
		Debug.Log ("Start Game");
//		SpeedManager.gameObject.SetActive(true);	
			
		           
    }


}
