using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadLemonBehaviourScript : MonoBehaviour
{
	public static bool ATTACK=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
	
	void OnCollisionEnter (Collision collision)
	{
		if(collision.collider.tag == "Player"){
			ATTACK = !ATTACK;
			GameControllerBehaviourScript.Evento += StateAttack;	
		}
	}

	void OnCollisionExit (Collision collision)
	{
		if(collision.collider.tag == "Player"){
			GameControllerBehaviourScript.Evento -= StateAttack;	
		}
	}

	void StateAttack(){
		if(ATTACK){
			foreach(GameObject o in GameObject.FindGameObjectsWithTag("badNPC"))
				o.GetComponent<Renderer>().material.color = Color.blue;
		}else{
			foreach(GameObject o in GameObject.FindGameObjectsWithTag("badNPC"))
				o.GetComponent<Renderer>().material.color = Color.yellow;
		}
	}
}
