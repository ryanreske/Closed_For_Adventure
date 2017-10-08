using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject EnemyHead;
	public GameObject EnemyBody;
	public GameObject EnemyArms;
	public GameObject EnemyFeet;

	// Use this for initialization
	void Start () {
		EnemyHead.GetComponent<Animator> ().SetBool ("IsTargetingHead", true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			if (EnemyHead.GetComponent<Animator> ().GetBool ("IsTargetingHead") == true) {

				EnemyHead.GetComponent<Animator> ().SetBool ("IsTargetingHead", false);
				EnemyHead.GetComponent<Animator> ().SetBool ("IsNotTargetingHead", true);
				EnemyBody.GetComponent<Animator> ().SetBool ("IsTargetingBody", true);
				EnemyBody.GetComponent<Animator> ().SetBool ("IsNotTargetingBody", false);
				print ("TargetingBody");
				return;
			}
			if (EnemyBody.GetComponent<Animator> ().GetBool ("IsTargetingBody") == true) {

				EnemyBody.GetComponent<Animator> ().SetBool ("IsTargetingBody", false);
				EnemyBody.GetComponent<Animator> ().SetBool ("IsNotTargetingBody", true);
				EnemyArms.GetComponent<Animator> ().SetBool ("IsTargetingArms", true);
				EnemyArms.GetComponent<Animator> ().SetBool ("IsNotTargetingtArms", false);
				print ("TargetingArms");
				return;
			}

			if (EnemyArms.GetComponent<Animator> ().GetBool ("IsTargetingArms") == true) {

				EnemyArms.GetComponent<Animator> ().SetBool ("IsTargetingArms", false);
				EnemyArms.GetComponent<Animator> ().SetBool ("IsNotTargetingArms", true);
				EnemyFeet.GetComponent<Animator> ().SetBool ("IsTargetingFeet", true);
				EnemyFeet.GetComponent<Animator> ().SetBool ("IsNotTargetingFeet", false);
				print ("TargetingFeet");
				return;
			}
			if (EnemyFeet.GetComponent<Animator> ().GetBool ("IsTargetingFeet") == true) {

				EnemyFeet.GetComponent<Animator> ().SetBool ("IsTargetingFeet", false);
				EnemyFeet.GetComponent<Animator> ().SetBool ("IsNotTargetingFeet", true);
				EnemyHead.GetComponent<Animator> ().SetBool ("IsTargetingHead", true);
				EnemyHead.GetComponent<Animator> ().SetBool ("IsNotTargetingHead", false);
				print ("TargetingHead");
				return;
			}


		}

	}

}
