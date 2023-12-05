using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Device;

[System.Serializable]
class AudioObject
{
    public string AName;
    public GameObject AObject;
}

public class AudioUI : MonoBehaviour
{
    [SerializeField] private AudioObject[] audios;
    
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
}
