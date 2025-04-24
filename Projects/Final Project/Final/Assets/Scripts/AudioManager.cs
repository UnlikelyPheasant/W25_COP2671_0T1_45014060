using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip audioClipClick;    // sound fx for box click

    public AudioClip audioClipDrop;     // sound fx for box dropped

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayClickClip()
    {
        audioSource.PlayOneShot(audioClipClick, .8f);
    }

    public void PlayDropClip()
    {
        audioSource.PlayOneShot(audioClipDrop, .8f);
    }

}
