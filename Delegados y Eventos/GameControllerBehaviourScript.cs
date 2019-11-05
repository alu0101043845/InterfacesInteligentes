using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void metodoDelegado();

public class GameControllerBehaviourScript : MonoBehaviour
{
    public static GameControllerBehaviourScript controlador;
	public static metodoDelegado Evento;

    private void Awake()
    {
        if(controlador == null)
        {
            controlador = this;
            DontDestroyOnLoad(this);
        } else if(controlador != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
			Evento += LightOnOff;
		
        
        if(Evento != null)
			Evento();
    }

	void LightOnOff()
    {
		Light myLight = GameObject.FindGameObjectWithTag("Spotlight").GetComponent(typeof(Light)) as Light;
		myLight.enabled = !myLight.enabled;
		Evento -= LightOnOff;
    }
}
