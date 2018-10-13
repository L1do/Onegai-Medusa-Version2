using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour {



	public GameObject firstGear;
	public GameObject secondGear;
	public GameObject zeroGear;



	
	void Awake () {
	firstGear = GameObject.FindGameObjectWithTag("FirstGear");
	secondGear = GameObject.FindGameObjectWithTag("SecondGear");
	zeroGear = GameObject.FindGameObjectWithTag("ZeroGear");
	}
	void Start () {
	firstGear.gameObject.SetActive(true);
	secondGear.gameObject.SetActive(false);
	zeroGear.gameObject.SetActive(false);	
	}
	
	
	void Update () {
		
	}

	void OnTriggerStay(Collider other) {

	Debug.Log ("Changed Gear!");
	
	zeroGear.gameObject.SetActive(true);
	firstGear.gameObject.SetActive(false);	
			

		}

}
