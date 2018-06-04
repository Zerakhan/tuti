// Patrol.cs
using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class Patrol2 : MonoBehaviour
{

    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    int MaxDist = 10;
    public GameObject Player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        Player = GameObject.FindGameObjectWithTag("Player");
        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
            agent.destination = Player.transform.position;
        else
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = Random.Range (0, points.Length - 1);
    }


    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();

        if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist)
            agent.destination = Player.transform.position;
    }
}
