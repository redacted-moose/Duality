using UnityEngine;
using System.Collections;

public class SkeletonAI : MonoBehaviour {

	public float lookRadius;
	public float attackRadius;
	public float movementSpeed;
	public float damping;
	public Transform target;

	float fpsTargetDistance;

	Renderer renderer;
	Rigidbody rigidbody;
	Animator animator;


	// Use this for initialization
	void Start () {
		renderer = GetComponent<Renderer>();
		rigidbody = GetComponent<Rigidbody>();
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		fpsTargetDistance = Vector3.Distance(target.position, transform.position);
		animator.SetFloat("Player Distance", fpsTargetDistance);

		if (fpsTargetDistance < lookRadius) {
			// Look at the player!
			Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotation, damping * Time.deltaTime);
			print("LOOK AT ME!");
		}

		if (fpsTargetDistance < attackRadius) {
			print("Attack!");
		}
	}
}
