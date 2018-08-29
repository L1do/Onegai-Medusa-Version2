using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AshibaManager02 : MonoBehaviour {

	
	GameObject player;
	GameObject PlayerLeftLeg;
	GameObject PlayerRightLeg;

	//private Color Red = new Color(24f, 100f, 100f, 21f);
/*
	public Material AshibaMaterial;

	public Material AshibaAtariMaterial;

	public GameObject ashiba001;
	public GameObject ashiba002;
	public GameObject ashiba003;
	public GameObject ashiba004;
	public GameObject ashiba005;
	public GameObject ashiba006;
*/

	// Use this for initialization
	void Start () {
	//AshibaMaterial = Material.GetComponent<AshibaMaterial>();
		//AshibaAtariMaterial = Material.FindGameObjectWithTag("AshibaAtariMaterial");

		player = GameObject.FindGameObjectWithTag("Player");
		PlayerLeftLeg = GameObject.FindGameObjectWithTag("LeftLeg");
		PlayerRightLeg = GameObject.FindGameObjectWithTag("RightLeg");
	/*
		ashiba001 = GameObject.FindGameObjectWithTag("ashiba001");
		ashiba002 = GameObject.FindGameObjectWithTag("ashiba002");
		ashiba003 = GameObject.FindGameObjectWithTag("ashiba003");
		ashiba004 = GameObject.FindGameObjectWithTag("ashiba004");
		ashiba005 = GameObject.FindGameObjectWithTag("ashiba005");
		ashiba006 = GameObject.FindGameObjectWithTag("ashiba006");

	*/	
		//Fetch the Renderer from the GameObject
        Renderer rend = GetComponent<Renderer>();

        //Set the main Color of the Material to green
        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.green);

        //Find the Specular shader and change its Color to red
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider PlayerRightLeg)
    {
		 
		Renderer rend001 = GetComponent<Renderer>();

       	//Set the main Color of the Material to green
        rend001.material.shader = Shader.Find("_Color");
        rend001.material.SetColor("_Color", Color.red);

        //Find the Specular shader and change its Color to red
        rend001.material.shader = Shader.Find("Specular");
        rend001.material.SetColor("_SpecColor", Color.green);
	 	
		Debug.Log ("右足が当たった");
	
             
    }
}
