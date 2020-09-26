using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinionAI : MonoBehaviour
{
    Animator animator;
    NavMeshAgent agent;
    public GameObject[] waypoints;
    int currWaypoint = -1;

    VelocityReporter velocity_reporter;
    GameObject moving_waypoint;
    public enum AIState
    {
        StaticWaypoints,
        MovingWaypoint
    }
    public AIState aIState = AIState.StaticWaypoints;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        animator = GetComponent<Animator>();

        setNextWaypoint();

        moving_waypoint = GameObject.FindWithTag("waypoint");
        if (moving_waypoint != null)
        {
            velocity_reporter = moving_waypoint.GetComponent<VelocityReporter>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("vely", agent.velocity.magnitude / agent.speed);
        switch (aIState)
        {
            case AIState.StaticWaypoints:
                if (currWaypoint == 0)
                {
                    print(agent.remainingDistance);
                }
                if (currWaypoint == 0 && agent.pathPending == false && agent.remainingDistance - agent.stoppingDistance <= 0)
                {
                    setNextWaypoint();
                }

                if (agent.pathPending == false && agent.remainingDistance == 0)
                {
                    setNextWaypoint();
                    if (currWaypoint == 5)
                    {
                        aIState = AIState.MovingWaypoint;
                    }
                }
                break;
            case AIState.MovingWaypoint:
                // Current distance to the moving waypoint
                float dist = Vector3.Distance(moving_waypoint.transform.position, this.transform.position);
                // Time agent needs to make this distance
                float lookAheadTime = Mathf.Clamp(dist / agent.speed, 1f, 1.4f);
                // Calculate predicted position of the moving waypoint based on the time
                Vector3 predictedPosition = moving_waypoint.transform.position + velocity_reporter.velocity * lookAheadTime;
                // Move agent to the predicted intercept position
                agent.SetDestination(predictedPosition);

                if (agent.remainingDistance - agent.stoppingDistance <= 0)
                {
                    setNextWaypoint();
                    aIState = AIState.StaticWaypoints;
                }
                break;
        }
    }

    private void setNextWaypoint()
    {
        if (waypoints != null)
        {
            if (currWaypoint < waypoints.Length - 1 && currWaypoint != -1)
            {
                currWaypoint++;
            }
            else
            {
                currWaypoint = 0;
            }
            agent.SetDestination(waypoints[currWaypoint].transform.position);

        }
        else
        {
            Debug.LogError("no waypoints found");
        }

    }
}
