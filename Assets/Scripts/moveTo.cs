using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    public Transform goal;
    NavMeshAgent agent;
    Vector3 offset;
    Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        offset = new Vector3(1, 0, 1);
        animator.SetBool("Chilling", true);
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, goal.position);
        Debug.Log(distance);
        if (distance > 2f)
        {
            animator.SetBool("Running", true);
            animator.SetBool("Grabbed", false);
            animator.SetBool("Chilling", false);
            agent.enabled = true;
            agent.destination = goal.position + offset;
        }
        else
        {
            agent.enabled = false;
            if (transform.position.y > 0)
            {
                animator.SetBool("Grabbed", true);
                animator.SetBool("Running", false);
                animator.SetBool("Chilling", false);
            }
            else
            {
                animator.SetBool("Chilling", true);
                animator.SetBool("Grabbed", false);
                animator.SetBool("Running", false);

            }
        }
    }

    public void appear()
    {
        transform.position = goal.position;
    }
}