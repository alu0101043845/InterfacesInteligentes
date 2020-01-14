using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void metodoDelegado();

public class GameControllerBehaviourScript : MonoBehaviour
{
    public static GameControllerBehaviourScript controlador;
	public static metodoDelegado Evento;
    public static int money = 100;
    public static int energy = 0;
    public Text MoneyText;
    public Text EnergyText;
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

        MoneyText.text = "" + money + " coins";
        EnergyText.text = "" + energy + " energy";
    }

	void LightOnOff()
    {
		Light myLight = GameObject.FindGameObjectWithTag("Spotlight").GetComponent(typeof(Light)) as Light;
		myLight.enabled = !myLight.enabled;
		Evento -= LightOnOff;
    }

    public void Buy()
    {
        if (money >= 10)
        {
            money -= 10;
            energy += 1;
            TigerBehaviourScript.force += (10 * energy);
            MoneyText.text = "" + money + " coins";
            EnergyText.text = "" + energy + " energy";
        }
    }
    public void updateT()
    {
        MoneyText.text = "" + money + " coins";
        EnergyText.text = "" + energy + " energy";
    }
}
