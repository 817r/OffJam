using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Device;

[System.Serializable]
class AudioObject
{
    public string AName;
    public GameObject AObject;
}

public class AudioControl : MonoBehaviour
{
    [SerializeField] private AudioObject[] audios;
    [SerializeField] private AudioMixer mixer;

    private void Awake()
    {
        if (mixer) mixer.SetFloat("LowpassFreq", 22000f);
    }

    public void PlayAudio(string AName)
    {
        foreach (var a in audios)
        {
            if (a.AName == AName) a.AObject.GetComponent<AudioSource>().Play();
            else a.AObject.GetComponent<AudioSource>().Stop();
        }
    }

    public void PlaySFX(string AName)
    {
        var sfx = audios.FirstOrDefault(s => s.AName == AName);
        sfx.AObject.GetComponent<AudioSource>().Play();
    }

    public void MuffleSound()
    {
        mixer.SetFloat("LowpassFreq", 500f);
    }

    public void UnmuffleSound()
    {
        mixer.SetFloat("LowpassFreq", 22000f);
    }
}
