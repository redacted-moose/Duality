using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public static Vector3 loadPosition = Vector3.zero;

	void Awake() {
		// DontDestroyOnLoad(this.gameObject);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    void OnLevelWasLoaded(int level)
    {
        this.gameObject.GetComponent<Transform>().position = loadPosition;
    }
}
