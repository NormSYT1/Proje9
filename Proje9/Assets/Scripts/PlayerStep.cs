using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStep : MonoBehaviour
{
    public GameObject footStep;
    void Start()
    {
       
    }
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            FootSteps();
        }
        else
        {
            StopFootSteps();
        }
    }
    public void FootSteps()
    {
        footStep.SetActive(true);
    }
    public void StopFootSteps()
    {
        footStep.SetActive(false);
    }
}
