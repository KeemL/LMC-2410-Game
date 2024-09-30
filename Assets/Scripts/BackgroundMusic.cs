using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Start playing the music (if not already playing)
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
