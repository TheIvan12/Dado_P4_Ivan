using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorCubo : MonoBehaviour
{

    public bool BotonX = false;

    public ParticleSystem particulas;

  

    public Cara3Sonido cara3;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            PulsacionJugador();
        }
    }

    public void PulsacionJugador()
    {


        // Me guardo un ray entre la cámara y la posicion del ratón
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(ray.origin, ray.direction, Color.red, 4);

        RaycastHit infoRayo;

        if (Physics.Raycast(ray, out infoRayo)) // Hago el raycast y guardo el raycasthit(informacion) en inforayo
        {
            if (infoRayo.transform.tag == "Boton") // si el rayo choca con un objeto con el tag Reset
            {
                // He chocado con el boton reset
                if (BotonX == false)
                {
                    Boton3DActivado();
                }

                else if (BotonX == true)
                {
                    Boton3DDesactivado();
                }

            }

            else if (infoRayo.transform.tag == "Sonido")
            {
                cara3.ReproduceSonido();
                Debug.Log("Reproduce sonido");
            }

        }
    }

    public void Boton3DActivado()
    {
        particulas.Play();
        BotonX = true;

    }

    public void Boton3DDesactivado()
    {
        particulas.Stop();
        BotonX = false;

    }
}
