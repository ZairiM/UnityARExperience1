using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInteraccion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches [0].phase == TouchPhase.Began){
            Debug.Log("Se detecto un touch!");
            Ray rayo = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
            RaycastHit ObjetoImpactado;



            if(Physics.Raycast(rayo, out ObjetoImpactado)){
                Debug.Log("Objeto impactado: " + ObjetoImpactado.transform.name);
                
                if(ObjetoImpactado.transform.gameObject.CompareTag("Cubo")){
                    ObjetoImpactado.transform.gameObject.SetActive(false);
                }
            }

        }
    }
}
