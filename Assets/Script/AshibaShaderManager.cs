using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AshibaShaderManager : MonoBehaviour {

	//set all the references you will use here
	GameObject player;
	GameObject PlayerLeftLeg;
	GameObject PlayerRightLeg;
	public Animator MaterialAnimator;
	public bool IsPlayingAnimation = false;
	//GameObject GreenPainter;
	//Shader Blueshader;
	//Shader GreenShader;
	//Shader YellowShader;
	//public Material AshibaShaderMaterialBlue;
	//public Material AshibaShaderMaterialGreen;
	//public Material AshibaShaderMaterialYellow;
	//Renderer RendHandler;
	

	void Awake()
	{	
		//get the animator component
		MaterialAnimator= GetComponent <Animator> ();
	}

	// Use this for initialization
	void Start () 
    {
    	
    	//find all the gameobjects using tag
		player = GameObject.FindGameObjectWithTag("Player");
		PlayerLeftLeg = GameObject.FindGameObjectWithTag("LeftLeg");
		PlayerRightLeg = GameObject.FindGameObjectWithTag("RightLeg");
		//GreenPainter = GameObject.FindGameObjectWithTag("GreenPainter");
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


	void Update ()

	{
		//MaterialAnimator.SetBool("Close");
	}
	
	// if ashiba colliders collide with another collider then start playing the animation
	void OnTriggerEnter(Collider other)
    {
    	MaterialAnimator= GetComponent <Animator> ();
    	//animator.SetBool("BOOLNAME"true);
    	//MaterialAnimation.SetBool("walk", true);

    	//MaterialAnimation = GetComponent <Animator> ();
    	//MaterialAnimation.Play("Cube");


    	//Renderer rend001 = GetComponent<Renderer>();

       	//Set the main Color of the Material to green
      //  rend001.material.shader = Shader.Find("_Color");
       // rend001.material.SetColor("_Color", Color.green);
        //Find the Specular shader and change its Color to red
      //  rend001.material.shader = Shader.Find("_Emission");
       //rend001.material.SetColor("_EmissionColor", Color.green);
	 	
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
