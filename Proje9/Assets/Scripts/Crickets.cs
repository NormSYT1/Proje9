using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crickets : MonoBehaviour
{
    public AudioSource audioSource;
    private float stopDistance = 5f;
    private Transform player;
    private float defaultVolume;
    void Start()
    {
        defaultVolume = audioSource.volume;
        player = FindObjectOfType<PlayerMove>().transform;
    }
    void Update()
    {
        if (player != null)
        {
            return;
        }
        else
        {
            float distance = Vector3.Distance(transform.position, player.position);
            if (distance > stopDistance)
            {
                audioSource.volume = defaultVolume;
            }
            else
            {
                audioSource.volume = 0f;
            }
        }
    }
}
