using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioManager instance;
    public AudioSource backgroundSource;
    public AudioSource sfxSource;

    public AudioClip background;
    public AudioClip jump;
    public AudioClip coinPickUp;

    public Slider backgroundMusicSlider;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        backgroundMusicSlider.value = backgroundSource.volume;
    }
    public void PlayJump()
    {
        PlaySound(jump);
    }

    public void PlayCoin()
    {
        PlaySound(coinPickUp);
    }


    private void PlaySound(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void VolumeSlider()
    {
        backgroundSource.volume = backgroundMusicSlider.value;
    }
}
