using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraShakeManager : MonoBehaviour
{
    // Transform of the camera to shake. Grabs the gameObject's transform
    // if null.

    public Transform camTransform;

    // How long the object should shake for.
    private float shakeDuration = 0f;

    // Amplitude of the shake. A larger value shakes the camera harder.
    private float shakeAmount = 0f;
    private float decreaseFactor = 0f;

    Vector3 originalPos;

    void Awake()
    {
        if (camTransform == null)
        {
            camTransform = GetComponent(typeof(Transform)) as Transform;
        }
        shakeDuration = 0f;
        shakeAmount = 0.0f;
        decreaseFactor = 0.0f;
        //Debug.Log("Awake shakeAmount is " + shakeAmount);
    }

    private void Start()
    {
       // StartCameraShake();
      //  Debug.Log("Start shakeAmount is " + shakeAmount);
    }


    void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

    void Update()
    {
        if (shakeDuration > 0)
        {
           // Debug.Log("shakeAmount " + shakeAmount);
            //  Debug.Log("Random.insideUnitSphere " + Random.insideUnitSphere);
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shakeDuration -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shakeDuration = 0f;
            //camTransform.localPosition = originalPos;
        }
    }

    /*public void StartCameraShake()
    {

            shakeDuration = 20f;
            shakeAmount = 10f;
            decreaseFactor = 0.0f;
            Debug.Log("shake");
    }*/

    void OnTriggerEnter(Collider other)
    {
        shakeDuration = 1f;
        shakeAmount = 0.1f;
        decreaseFactor = 0.0f;

    }



    void OnTriggerExit(Collider other)
    {
       shakeDuration = 0f;
       shakeAmount = 0.0f;
       decreaseFactor = 0.0f;
     //   isCameraShaking = false;
    }
}

