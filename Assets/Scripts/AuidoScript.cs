using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AuidoScript : MonoBehaviour
{
    public Sonidos[] sounds;

    public bool Playing;

    public static AuidoScript instance;
   

    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        
 

        foreach ( Sonidos s in sounds)
        {
            s._source = gameObject.AddComponent<AudioSource>();

            s._source.clip = s.clip;
            s._source.volume = s.volume;
            s._source.pitch = s.pitch;
            s._source.loop = s.loop;
            s._source.mute = s.mute;
        }
    }

    private void Start()
    {
        Playing = true;
        if (Playing)
        {
            Play("Marcha");
        }
    }

    // Update is called once per frame
    public void Play (string name)
    {
        if (Playing)
        {
            Sonidos s = Array.Find(sounds, Sonidos => Sonidos.Name == name);
            s._source.Play();
        }
        
    }
    public void Stop(string name)
    {
        Sonidos s = Array.Find(sounds, Sonidos => Sonidos.Name == name);
        s._source.Stop();
    }

    public void Mute(string name)
    {
        Sonidos s = Array.Find(sounds, Sonidos => Sonidos.Name == name);
        if (s._source.mute == true) { s._source.mute = false; }
        else { s._source.mute = true; }
    }

    public void Force_Play(string name)
    {
        Sonidos s = Array.Find(sounds, Sonidos => Sonidos.Name == name);
        s._source.mute = false;
    }

    public void Set_Volume(string name, float _volume)
    {
        Sonidos s = Array.Find(sounds, Sonidos => Sonidos.Name == name);
        s._source.volume = _volume;
    }
}
