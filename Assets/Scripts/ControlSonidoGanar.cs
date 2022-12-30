using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonidoGanar : MonoBehaviour
{
    public AudioSource sonidoGanaste;
    // Start is called before the first frame update
    void Start()
    {
        this.sonidoGanaste.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //this.sonidoGanaste.Play();
    }
}
