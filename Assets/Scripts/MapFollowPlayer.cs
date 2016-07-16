using UnityEngine;
using System.Collections;

public class MapFollowPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		Transform target = MouseOrbitImproved.target;

		float x = target.transform.position.x;
		float z = target.transform.position.z;

		transform.position = new Vector3 (x, 100.0f, z);
		//mapTrans.position.z = 200.0f;




	}

}
