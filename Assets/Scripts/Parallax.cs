using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject miCamara;
    public float paralaxSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        miCamara = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
       
       void FixedUpdate(){
        transform.position = new Vector3(Camera.main.transform.position.x/paralaxSpeed, Camera.main.transform.position.y/paralaxSpeed, 0);
       }
}
