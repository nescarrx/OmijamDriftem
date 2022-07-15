using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class MusicLists : MonoBehaviour
{
    [SerializeField] private AudioClip[] musicClips;
    [SerializeField] private int currentTrack;
    [SerializeField] private AudioSource source;

    [SerializeField] private Text clipTitleText;

    [SerializeField] private GameObject Play;
    [SerializeField] private GameObject Stop;
    
    private void Start()
    {
        source = GetComponent<AudioSource>();

        PlayMusic();
    }

    public void StopMusic()
    {
        StopCoroutine(nameof(WaitForMusicEnd));
        source.Stop();
        Play.SetActive(true);
        Stop.SetActive(false);
    }
    public void PlayMusic()
    {
        if (source.isPlaying)
        {
            return;
        }
        currentTrack--;
        if (currentTrack<0)
        {
            currentTrack = musicClips.Length - 1;
        }
        StartCoroutine(nameof(WaitForMusicEnd));
        Play.SetActive(false);
        Stop.SetActive(true);
    }

    IEnumerator WaitForMusicEnd()
    {
        while (source.isPlaying)
        {
            yield return null;
        }
        NextTitle();
    }

    public void NextTitle()
    {
        source.Stop();
        currentTrack++;
        if(currentTrack>musicClips.Length - 1)
        {
            currentTrack = 0;
        }
        source.clip = musicClips[currentTrack];
        source.Play();

        //Title
        ShowCurrentTitle();

        StartCoroutine(nameof(WaitForMusicEnd));
        Play.SetActive(false);
        Stop.SetActive(true);
    }

    public void PreviousTitle()
    {
        source.Stop();
        currentTrack--;
        if (currentTrack < 0)
        {
            currentTrack = musicClips.Length - 1;
        }
        source.clip = musicClips[currentTrack];
        source.Play();

        //Title
        ShowCurrentTitle();

        StartCoroutine(nameof(WaitForMusicEnd));
        Play.SetActive(false);
        Stop.SetActive(true);
    }

    void ShowCurrentTitle()
    {
        clipTitleText.text = source.clip.name;
    }
}

