using UnityEngine;
using System.Collections;

public class Spider : MonoBehaviour {

	GameObject spider;

	// Use this for initialization
	void Start () {

		spider = GameObject.FindGameObjectWithTag ("spider");
	
	}
	
	// Update is called once per frame
	void Update () {
	/*
		if( spider == null){

			print ("spider not found");
		}

		if (Input.GetKey (KeyCode.W) || Input.GetKey(KeyCode.UpArrow) ) {


			spider.transform.position += Vector3.forward * 2.0f;


		}


		if (Input.GetKey (KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {

			spider.transform.position += Vector3.back * 2.0f;

		}

		if (Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {


			spider.transform.position += Vector3.left * 2.0f;


		}
*/
		if (Input.GetKey (KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {

			/*
			Vector3 rot = spider.transform.TransformVector;

			rot.x += + 30.0f;

			spider.transform.rotation = Quaternion.LookRotation (rot);



*/
		}

	}




}
