using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    bool contacto = false;
    Color[] colores = new Color[4]{Color.red, Color.green, Color.yellow, Color.blue };
    int index = 0;
    // Start is called before the first frame update
    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Q))&&contacto)
        {
            ChangeColor();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
            contacto = true;
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Player")
            contacto = false;
    }
    public void ChangeColor()
    {
        this.GetComponent<Renderer>().material.color = colores[index];
        if (index < 3)
            index++;
        else
            index = 0;
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
}
