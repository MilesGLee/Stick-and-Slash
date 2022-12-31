using UnityEngine.AI;
using UnityEngine;

[RequireComponent(typeof(NavMeshAgent)), RequireComponent(typeof(Rigidbody))]
public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    //Temporary health container
    private float _health;

    [SerializeField]
    //Temporary health container
    private float _speed;

    [SerializeField]
    //Unities path finding algorithm
    private NavMeshAgent agent;

    [SerializeField]
    private Transform player;


    private void Awake()
    {
        agent.speed = _speed;
    }

    // Update is called once per frame
    void Update()
    {
        //Moves to the position assined 
        agent.SetDestination(player.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Checks if there is a script attached to this collision 
        IsAnAbility playersAbility = collision.gameObject.GetComponent<IsAnAbility>();

        if (!playersAbility)
            return;

        //Is so remove from health bar 
       _health -= playersAbility.Attack.AbilityDamage;

        //If health is below this threshold 
        if (_health <= 0.0f)
            //It destroies this object
            Destroy(gameObject);
    }
}
