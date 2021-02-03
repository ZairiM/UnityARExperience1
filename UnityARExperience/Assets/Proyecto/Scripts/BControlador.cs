using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BControlador : MonoBehaviour
{
    private GameObject local;
    private AudioSource m_MyAudioSource;
    void Start()
    {
       local = GameObject.Find("BananaB");
       m_MyAudioSource = local.gameObject.GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches [0].phase == TouchPhase.Began){
            Debug.Log("Se detecto un touch!");
            Ray rayo = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
            RaycastHit ObjetoImpactado;



            if(Physics.Raycast(rayo, out ObjetoImpactado)){
                Debug.Log("Objeto impactado: " + ObjetoImpactado.transform.name);
                
                if(ObjetoImpactado.transform.gameObject.CompareTag("CuboB")){
                    //ObjetoImpactado.transform.gameObject.SetActive(false);
                    
                    local.gameObject.SetActive(true);
                    m_MyAudioSource.Play();
                }
            }

        }
    }
}

