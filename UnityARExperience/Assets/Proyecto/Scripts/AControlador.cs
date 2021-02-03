using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AControlador : MonoBehaviour
{
    public CoupleButtonController[] buttons;
    public int time = 0;
    public int parejasTotales;
    public GameObject panel;
    
    public bool estaJugando = true;

    void Start()
    {
        buttons = FindObjectsOfType<CoupleButtonController>();
        parejasTotales = 10;
        
    }

    public CoupleButtonController GetActiveButton(CoupleButtonController currentButton)
    {
        for(int i = 0; i < buttons.Length; i++){
            if(buttons[i].active && buttons[i] != currentButton)
            {
                return buttons[i];
            }
        }
        return null;
    }

    void Update()
    {
        
    }

    public void FinalizarJuego(){
        if(parejasTotales == 0){
            print("Se acabó");
            estaJugando = false;
            panel.SetActive(true);

        }
    }

    public void RestartGame ()
    {
            Application.LoadLevel(Application.loadedLevel);
        
        //Buscar como reiniciar (cargar la escena por su nombre)
    }

}