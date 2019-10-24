using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroBehaviourScript : MonoBehaviour
{
	private bool choqueEntra;
	private bool choqueSale;
	private int contadorSale;
	private int contadorEntra;
    // Start is called before the first frame update
    void Start()
    {
		this.GetComponent<Renderer>().material.color = Color.green;
		choqueEntra = false;
        contadorSale = 0;
		choqueSale = false;
        contadorEntra = 0;
    }

    // Update is called once per frame
    void Update()
    {
		if(choqueSale)
			contadorSale++;
		
		if(contadorSale >= 10)
		{
			this.GetComponent<Renderer>().material.color = Color.green;
			choqueSale = false;
			contadorSale = 0;
		}
        
    }
	
	void OnCollisionEnter (Collision collision)
	{
		this.GetComponent<Renderer>().material.color = Color.red;
		choqueEntra = true;
		choqueSale = false;
	}
	
	void OnCollisionStay (Collision collision)
	{
		if(choqueEntra)
			contadorEntra++;
		
		if(contadorEntra >= 10)
		{
			this.GetComponent<Renderer>().material.color = new Color(1, 0.5f, 0);
			choqueEntra = false;
			contadorEntra = 0;
		}
	}

	void OnCollisionExit (Collision collision)
	{
		this.GetComponent<Renderer>().material.color = Color.yellow;
		choqueSale = true;
		choqueEntra = false;
	}
}
