using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decrece : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool contacto = false;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && contacto)
        {
            float escala =  (1 + GameControllerBehaviourScript.energy);
            escala = 1f / escala;
            //this.transform.localScale *= 0.5f;
            print(escala);
            this.transform.localScale *= escala;
        }
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
            contacto = true;
    }
    private void OnTriggerStay(Collider collision)
    {

        contacto = true;
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "Player")
            contacto = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
            contacto = true;
    
    }
  

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Player")
            contacto = true;
        
    }
}
