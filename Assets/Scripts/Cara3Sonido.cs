using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cara3Sonido : MonoBehaviour
{
    public AudioClip sonido;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReproduceSonido()
    {
        GestorSonido.instance.playSFX(sonido);
    }
}
