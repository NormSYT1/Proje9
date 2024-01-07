using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicZone : MonoBehaviour
{
    public AudioSource audioSource;
    private float fadeTime = 5f;
    private float targetVolume;
    void Start()
    {
        targetVolume = 0.0f;
        audioSource.volume = 0.0f;
    }
    void Update()
    {
        audioSource.volume = Mathf.MoveTowards(audioSource.volume, targetVolume, (1.0f / fadeTime) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetVolume = 1.0f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetVolume = 0.0f;
        }
    }
}
