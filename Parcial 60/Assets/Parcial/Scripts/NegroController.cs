using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegroController : MonoBehaviour
{

    // Start is called before the first frame update
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Rojo"))
        {
            other.GetComponent<Rigidbody>().useGravity = true;

            print("rojo");

        }else if(other.gameObject.CompareTag("Azul")){
            print("azul");
            other.gameObject.SetActive(false);
        }
        else if(other.gameObject.CompareTag("Amarillo")){

            print("amarillo");
            
            
        }
        else if(other.gameObject.CompareTag("Verde")){
            print("verde");
            other.gameObject.GetComponent<Renderer>().material.color = Color.black;
            
        }
    }
}
