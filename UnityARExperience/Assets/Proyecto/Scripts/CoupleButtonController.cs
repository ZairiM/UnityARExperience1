using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ButtonType
{
    none,
    Avocado,
    Banana,
    Coconut,
    IceCream,
    Mushroom,
    Onion,
    Pineapple,
    SweetPepper,
    Tomato,
    WaterMelon
};

public class CoupleButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public ButtonType buttonType = ButtonType.none;

    public CoupleButtonController Pareja;

    public GameObject hiddenItem;
    private AControlador controlador;
    public bool active;

    void Start()
    {
        active = false;
        controlador = GameObject.Find("AControlador").GetComponent<AControlador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

            if(hiddenItem != null)
            {
                hiddenItem.SetActive(!active);
                PlaySound();
                active= !active;
                CheckPareja();
            }
        
    }

    private void CheckPareja()
    {
        if(Pareja != null)
        {
            if(Pareja.active)
            {
                Invoke("OnParejaFound", 1.5f);
            }else if(controlador.GetActiveButton(this) != null)
            {
                Invoke("OnParejaNotFound", 1.5f);
            }
        }
    }

    private void HideAll()
    {
        active = false;
        hiddenItem.SetActive(false);
        gameObject.SetActive(false);
        
    }
    private void Hide(){
        active = false;
        hiddenItem.SetActive(false);
    }
    private void PlaySound ()
    {
        if(hiddenItem != null)
        {
            AudioSource sonido = hiddenItem.GetComponent<AudioSource>();
            
            if(sonido != null)
            {
                sonido.Play();
            }
        }
    }

    private void OnParejaFound()
    {
    //Check If all parejas
       Pareja.HideAll();
       this.HideAll();
       controlador.parejasTotales--;
       controlador.FinalizarJuego();
    }

    private void OnParejaNotFound()
    {
       controlador.GetActiveButton(this).Hide();
       Hide();
       
    }
}
