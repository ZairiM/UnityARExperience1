using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotador : MonoBehaviour
{
    // Start is called before the first frame update
    public bool rotar;
    void Start()
    {
        rotar = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(rotar == true){
        transform.Rotate(new Vector3 (60,60,60) * Time.deltaTime);}
        
    }
    void OnTriggerEnter(Collider other)
    {
        rotar = true;
    }
}
