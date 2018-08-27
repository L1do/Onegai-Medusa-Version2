using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AshibaManager : MonoBehaviour {

	GameObject player;

	public Material AshibaMaterial;

	public Material AshibaAtariMaterial;

	public GameObject ashiba001;
	public GameObject ashiba002;
	public GameObject ashiba003;
	public GameObject ashiba004;
	public GameObject ashiba005;
	public GameObject ashiba006;

	// Use this for initialization
	void Start () {
		//AshibaMaterial = Material.GetComponent<AshibaMaterial>();
		//AshibaAtariMaterial = Material.FindGameObjectWithTag("AshibaAtariMaterial");

		player = GameObject.FindGameObjectWithTag("Player");

		ashiba001 = GameObject.FindGameObjectWithTag("ashiba001");
		ashiba002 = GameObject.FindGameObjectWithTag("ashiba002");
		ashiba003 = GameObject.FindGameObjectWithTag("ashiba003");
		ashiba004 = GameObject.FindGameObjectWithTag("ashiba004");
		ashiba005 = GameObject.FindGameObjectWithTag("ashiba005");
		ashiba006 = GameObject.FindGameObjectWithTag("ashiba006");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnTriggerStay(Collider other)
    {
       // if (other.attachedRigidbody)
     //     ashiba002.AddComponent AshibaAtariMaterial;
    }
}
