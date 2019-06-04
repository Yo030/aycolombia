using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons_Scripts : MonoBehaviour
{
    public bool _on_off;

    public GameObject Boton_musica;

    public Animator anim_Boton_musica;

    private void Start()
    {
        _on_off = true;
    }

    public void pause()
    {
        if(_on_off == false) { _on_off = true; }
        else { _on_off = false; }
        AuidoScript.instance.Mute("Marcha");
        anim_Boton_musica.SetBool("Activado", _on_off);
    }

    public void loadSound(string _stringname)
    {
        AuidoScript.instance.Play(_stringname);
    }

    public void Set_Volume(string _stringname)
    {
        AuidoScript.instance.Set_Volume(_stringname, 0.25f);
    }
}
