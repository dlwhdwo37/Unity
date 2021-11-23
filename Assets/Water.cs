using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
	void OnTriggerEnter(Collider coll)
	{
		if (coll.tag == "Player")
		{
			GetComponent<AudioSource>().Play();
		}
	}


}
