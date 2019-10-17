## Explicación
Para poder realizar el movimiento de traslación de una esfera usando las tecas wsad y las flechas de control y la rotación sobre el eje y con las teclas qe, lo primero es crear la esfera en cuestión, y a continuación añadirle un componente, seleccionando la opción de "New script". En este incluiremos los comandos descritos a debajo para añadir las funcionalidades deseadas al objeto

## Script
    using System.Collections;
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    public class CubeBehaviourScript : MonoBehaviour
    {
    private Transform tf;   //objeto Transform con el que realizaremos las transformaciones
    public float velocidad; //parámetro público que indica la velocidad de desplazamiento, puede ser editada directamente en Unity
    // Start is called before the first frame update
    void Start()
    {
        tf = this.GetComponent<Transform>();    //Obtenemos el transform de la esfera
        velocidad = 1;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))    //si está pulsada la tecla W o la flecha hacia arriba la esfera se desplaza hacia delante
            {
                tf.Translate(Vector3.forward * velocidad);
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))    //si está pulsada la tecla D o la flecha derecha la esfera se desplaza hacia la derecha
            {
                tf.Translate(Vector3.right * velocidad);
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))    //si está pulsada la tecla S o la flecha hacia abajo la esfera se desplaza hacia atrás
            {
                tf.Translate(Vector3.back * velocidad);
            }
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))    //si está pulsada la tecla A o la flecha izquierda la esfera se desplaza hacia la izquierda
            {
                tf.Translate(Vector3.left * velocidad);
            }
            if (Input.GetKey(KeyCode.Q))    //si está pulsada la tecla Q la esfera rota en el eje y en sentido antihorario
            {
                tf.Rotate(Vector3.up * -1);
            }
            if (Input.GetKey(KeyCode.E))    //si está pulsada la tecla Q la esfera rota en el eje
            {
                tf.Rotate(Vector3.up);
            }
        }
    }

## Ejecución
<img src="./MovementGif.gif" width="800">
