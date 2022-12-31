using UnityEngine.AI;
using UnityEngine;


[RequireComponent(typeof(NavMeshAgent)),RequireComponent(typeof(Rigidbody))]
public class EnemyMovment : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent agent;

    [SerializeField]
    private Transform player;
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
}
