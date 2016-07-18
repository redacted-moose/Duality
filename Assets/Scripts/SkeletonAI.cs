using UnityEngine;
using System.Collections;

public class SkeletonAI : MonoBehaviour
{

    public float lookRadius;
    public float attackRadius;
    public float movementSpeed;
    public float damping;
    Transform target;

    float fpsTargetDistance;

    // Renderer renderer;
    // Rigidbody rigidbody;
    Animator animator;
    NavMeshAgent agent;
    // Transform transform;


    // Use this for initialization
    void Start()
    {
        // renderer = GetComponent<Renderer>();
        // rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        // transform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        HUDController hud = HUDController.getSingleton();
        HUDController.SinOrSol currentCharacter = hud.whoAmI;
        switch (currentCharacter) {
            case HUDController.SinOrSol.Sin:
                target = GameObject.FindWithTag("Sin-Character").GetComponent<Transform>();
            break;

            case HUDController.SinOrSol.Sol:
                target = GameObject.FindWithTag("Sol-Character").GetComponent<Transform>();
                break;
        }
        fpsTargetDistance = Vector3.Distance(target.position, transform.position);
        if (fpsTargetDistance >= lookRadius || target == null)
        {
            animator.SetFloat("Player Distance", fpsTargetDistance);
            return;
        }

        agent.SetDestination(target.position);
        agent.speed = movementSpeed;
        animator.SetFloat("Player Distance", agent.remainingDistance);
        if (agent.remainingDistance < lookRadius)
        {
            // Look at the player!
            Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
            // transform.rotation = Quaternion.Slerp(transform.rotation, rotation, damping * Time.deltaTime);
            transform.rotation = rotation;
            print("LOOK AT ME!");
            if (agent.remainingDistance > agent.stoppingDistance)
            {
                Move(agent.desiredVelocity);
            }
            else
            {
                Move(Vector3.zero);
            }
        }

        if (agent.remainingDistance < attackRadius)
        {
            print("Attack!");
        }
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    private void Move(Vector3 velocity)
    {
        transform.position += velocity * Time.deltaTime;
    }
}
