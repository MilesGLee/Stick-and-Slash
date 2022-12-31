using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _health;
    
    private void OnCollisionEnter(Collision collision)
    {
        //Checks if there is a script attached to this collision 
        IsAnAbility playersAbility = collision.gameObject.GetComponent<IsAnAbility>();

        if (!playersAbility)
            return;

        //Is so remove from health bar 
       _health -= playersAbility.Attack.AbilityDamage;

        if(_health <= 0.0f)
            Destroy(gameObject);
    }
}
