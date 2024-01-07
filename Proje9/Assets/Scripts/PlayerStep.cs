using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStep : MonoBehaviour
{
    public AudioClip[] footSteps;
    public AudioSource audioSource;
    public CharacterController controller;
    private float footStepThesHold = 0.3f;
    private float footStepRate = 0.5f;
    private float lastFootStepTime;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (controller.velocity.magnitude > footStepThesHold)
        {
            if (Time.time - lastFootStepTime > footStepRate) 
            {
                lastFootStepTime = Time.time;
                audioSource.PlayOneShot(footSteps[Random.Range(0, footSteps.Length)]);
            }
        }
    }
}
