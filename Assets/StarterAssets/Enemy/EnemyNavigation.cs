    using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    public NavMeshAgent Agent;
    public Transform Player;
    public float InitialDelay;
    public float Interval;

    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;

        InvokeRepeating("SetDestination", InitialDelay, Interval);
    }

    public void SetDestination()
    {
        Agent.destination = Player.position;
    }
}
