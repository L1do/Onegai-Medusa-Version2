using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroGearManager : MonoBehaviour {
	public float normalSpeed = 0f;
	public GameObject SpeedBump001;
	//private FirstGearManager speedManager;
	public GameObject AshibaSet001;
	public GameObject AshibaSet002;
	public GameObject PoseStage001;
	public GameObject PoseStage002;


	void Awake () {
	AshibaSet001 = GameObject.FindGameObjectWithTag("AshibaSet001");
	AshibaSet002 = GameObject.FindGameObjectWithTag("AshibaSet002");
	PoseStage001 = GameObject.FindGameObjectWithTag("PoseStage001");
	SpeedBump001 = GameObject.FindGameObjectWithTag("SpeedBump001");
	PoseStage002 = GameObject.FindGameObjectWithTag("PoseStage002");

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	AshibaSet001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	AshibaSet002.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	PoseStage001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	SpeedBump001.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
	PoseStage002.transform.Translate(-Vector3.forward* normalSpeed * Time.deltaTime);
		
	/*Vector3 pos = this.gameObject.transform.localPosition;
    pos.z += 0f;
    this.gameObject.transform.localPosition = pos;*/	
	}
}
