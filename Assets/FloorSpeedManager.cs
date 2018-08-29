using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpeedManager : MonoBehaviour {

	public ScriptableObject RailManager;
	 public float speed = 0.01F;
	 

	// Use this for initialization
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
    {
		
    	
	 	Debug.Log　("「Speed bump」に当たった");

	
             
    }
}
