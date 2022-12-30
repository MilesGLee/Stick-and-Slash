using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class AttackStats : ScriptableObject
{
    //The name of this ability 
    [Tooltip("The name of this ability "),SerializeField]
    private string _abilityName = "defult";

    [Tooltip("For short discription of the ability maybe even lore"), SerializeField]
    private string _abilityDiscription = "None";

    [Tooltip("if under cooldown"), SerializeField]
    private bool _isUnderCooldown = false;

    [Tooltip("Current ability damage out put"), SerializeField]
    private float _abilityDamage = 0.0f;

    [Tooltip("Cooldown after use"), SerializeField]
    private float _abilityCooldown = 0.0f;

    public string AbilityName { get => _abilityName; }
    public string AbilityDiscription { get => _abilityDiscription; }
    public bool IsUnderCooldown { get => _isUnderCooldown; set => _isUnderCooldown = value; }
    public float AbilityDamage { get => _abilityDamage; }
    public float AbilityCooldown { get => _abilityCooldown; }

}
