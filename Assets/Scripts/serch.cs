using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serch : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)      
    {
        if (other.gameObject.tag == "Player")
        {
           
            GetComponentInParent<ghostmove>().enabled = false;
            GetComponentInParent<ghost>().enabled = false;
            GetComponentInParent<chase>().enabled = true;
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            GetComponentInParent<ghostmove>().enabled = true;
            GetComponentInParent<ghost>().enabled = true;
            GetComponentInParent<chase>().enabled = false;
            
        }
    }
}
