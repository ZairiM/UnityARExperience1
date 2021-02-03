using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ControlBotones : MonoBehaviour, IVirtualButtonEventHandler 
{

    public GameObject buttonObjectA;
    public GameObject buttonObjectAz;
    public GameObject buttonObjectR;
    private GameObject cubo;
    private Material materialCubo;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.Find("Cubo");
        materialCubo = cubo.GetComponent<Renderer>().material;

        
        buttonObjectA.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

       
        buttonObjectAz.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        buttonObjectR.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){

        Debug.Log("Boton Presionado");

        switch (vb.VirtualButtonName){
            case "BotonAmarillo":
                Debug.Log("Amarillo");
                materialCubo.color = Color.yellow;
            break;
            case "BotonRojo":
                Debug.Log("Rojo");
                materialCubo.color = Color.red;
            break;
            case "BotonAzul":
                Debug.Log("Azul");
                materialCubo.color = Color.blue;
            break;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){

        Debug.Log("Boton Liberado");
       // materialCubo.color = Color.white;
         
    }
}
