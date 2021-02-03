using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelTextController : MonoBehaviour
{
    // Start is called before the first frame update
    public  AControlador controlador;
    public Text txtPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    txtPanel.text = "Felicitaciones Encontraste Todas Las Parejas En "  + controlador.time.ToString() + " Segundos" ;    
    }
}
    
    

    
