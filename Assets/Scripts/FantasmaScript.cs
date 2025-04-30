using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{

     Vector3 posicionInicial;
     GameObject personaje;
     public float velocidadFantasma = 10.0f;

     AudioSource _audioSource;


    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
        personaje = GameObject.FindGameObjectWithTag("Player");
        _audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         float distancia = Vector3.Distance(transform.position, personaje.transform.position);
         float velocidadFinal = velocidadFantasma * Time.deltaTime;

         if(distancia <= 4.1f){
             //ACCION
             // Debug.DrawLine(transform.position, personaje.transform.position, Color.red, 2.5f);

              transform.position = Vector3.MoveTowards(transform.position, personaje.transform.position, velocidadFinal);
              
              if(_audioSource.isPlaying == false){
                _audioSource.Play();
              }

         }else{
            //VUELTA A CASA
            transform.position = Vector3.MoveTowards(transform.position, posicionInicial, velocidadFinal);
            
             if((transform.position == posicionInicial) && _audioSource.isPlaying == true){
                _audioSource.Stop();
             }
            
         }
           //Debug.DrawLine(transform.position, personaje.transform.position, Color.white, 2.5f);
    }
}
