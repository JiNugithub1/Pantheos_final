using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip yutSound;

    // Animation Event에 의해 호출될 함수
    public void PlayYutSound()
    {
        if (audioSource != null && yutSound != null)
        {
            audioSource.PlayOneShot(yutSound);
        }
    }
}
