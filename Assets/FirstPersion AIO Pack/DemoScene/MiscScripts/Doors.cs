using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {
	//private AudioClip clip;
	//private Animator anim;


	void OnTriggerEnter(Collider coll){
		if(coll.tag=="Player"){
			GetComponent<Animator>().Play("Door_open");
			//GetComponent<AudioSource>().clip;
			//anim.SetBool("IsOpen", true);
			GetComponent<AudioSource>().Play();
			//this.enabled=false;
		}
	}
}
