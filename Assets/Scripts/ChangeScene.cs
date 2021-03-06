using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public enum DualityScene {
	Cave = 1,
	Forest = 2,
	Village = 3
}

public class ChangeScene : MonoBehaviour {

	public DualityScene target;
	public float x;
	public float y;
	public float z;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider other)
    {
		// other.gameObject.GetComponent<Transform>().position = new Vector3(x, y, z);
		GameObject player = other.gameObject;
        SceneManager.LoadScene((int)target);
		if (player.tag == "Sin-Character" || player.tag == "Sol-Character") {
			// Transform t = player.GetComponent<Transform>().transform;
			// t.position = new Vector3(x, y, z);
            Player.loadPosition = new Vector3(x, y, z);
		}
    }
}
