using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.tag == "Player")
		
		{
			Destroy (gameObject);	
		
		}

	}
}