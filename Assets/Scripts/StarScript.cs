using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{

    Animator myAnimadorController;
    // Start is called before the first frame update
    void Start()
    {
        myAnimadorController = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col){
        
        if(col.name == "Personaje"){
            GameManager.puntos  += 3;
            myAnimadorController.SetBool("starDestruir", true);
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxShine);
            Destroy(this.gameObject, 0.5f);
            
            
        }
    }
}
