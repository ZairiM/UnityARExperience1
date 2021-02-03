using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public  AControlador controlador;
    public Text txtTime;

    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        while(controlador.estaJugando)
        {
            yield return new WaitForSeconds (1);
            
            controlador.time ++;

            if(txtTime != null)
            {
                txtTime.text = controlador.time.ToString();
            }else
            {
                Debug.LogError("No hay un text box asociado");
            }
            
        }
    }
    
}
