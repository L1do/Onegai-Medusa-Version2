using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AshibaShaderManager : MonoBehaviour {
	GameObject player;
	GameObject PlayerLeftLeg;
	GameObject PlayerRightLeg;
	GameObject GreenPainter;
	//Shader Blueshader;
	//Shader GreenShader;
	//Shader YellowShader;
	public Material AshibaShaderMaterialBlue;
	public Material AshibaShaderMaterialGreen;
	public Material AshibaShaderMaterialYellow;
	//Renderer RendHandler;

	// Use this for initialization
	void Start () 
    {

		player = GameObject.FindGameObjectWithTag("Player");
		PlayerLeftLeg = GameObject.FindGameObjectWithTag("LeftLeg");
		PlayerRightLeg = GameObject.FindGameObjectWithTag("RightLeg");
		GreenPainter = GameObject.FindGameObjectWithTag("GreenPainter");
	//	AshibaShaderMaterialBlue = Find

	/*	//Fetch the Renderer from the GameObject
        Renderer rend = GetComponent<Renderer>();

        //Set the main Color of the Material to green
        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.blue);

        //Find the Specular shader and change its Color to red
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.blue);*/
	}
	

	void OnTriggerEnter(Collider other)
    {
    	Renderer rend001 = GetComponent<Renderer>();

       	//Set the main Color of the Material to green
        rend001.material.shader = Shader.Find("_Color");
        rend001.material.SetColor("_Color", Color.green);
        //Find the Specular shader and change its Color to red
        rend001.material.shader = Shader.Find("Emission");
       rend001.material.SetColor("_Emission", Color.green);
	 	
		Debug.Log ("左足が当たった");
		           
    }

	/*void OnTriggerExit(Collider other)
    {
		  
		Renderer rend001 = GetComponent<Renderer>();

       	//Set the main Color of the Material to green
        rend001.material.shader = Shader.Find("_Color");
        rend001.material.SetColor("_Color", Color.yellow);

        //Find the Specular shader and change its Color to red
        rend001.material.shader = Shader.Find("Specular");
        rend001.material.SetColor("_SpecColor", Color.yellow);
	 	
		//Debug.Log ("左足が当たった");
		           
    }*/
}
