using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class TweenManager : MonoBehaviour {

    public Transform cubeB;

    // Use this for initialization
    void Start () {
        DOTween.To(() => cubeB.position, x => cubeB.position = x, new Vector3(0, 7, 0), 1).SetRelative().SetLoops(-1, LoopType.Yoyo);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
