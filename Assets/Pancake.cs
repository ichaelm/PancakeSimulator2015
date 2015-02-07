using UnityEngine;
using System.Collections;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class Pancake : MonoBehaviour {
	public bool start;
	public GameObject myo = null;
	public float cooktime = 0;
	public float burntime;
	public Color uncookedcolor;
	public Color burntcolor;


	// Use this for initialization
	void Start () {
		//start = false;
		//transform.rigidbody.useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		//ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();
		//if (thalmicMyo.pose == Pose.Fist && start == false) {
		//	start = true;
		//	transform.rigidbody.useGravity=true;
		//}
		if (Input.GetKeyDown ("p")) {
			transform.rigidbody.velocity = new Vector3(0f, 0f, 0f) ;
			transform.position = new Vector3 (0f, 1.0f, 3.75f);
			transform.rotation.Set(0f,0f,0f,1f);
			transform.rigidbody.angularVelocity.Set(0f,0f,0f);
			transform.rigidbody.useGravity = true;
			cooktime = 0;
		}

		renderer.material.color = Color.Lerp (uncookedcolor, burntcolor, cooktime / burntime);

	}

	void OnCollisionStay(Collision collisionInfo){
		cooktime = cooktime + Time.deltaTime;
	}
}
