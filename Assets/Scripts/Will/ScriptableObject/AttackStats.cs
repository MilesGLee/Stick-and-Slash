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

    //Alows classes to access the values of the ability name 
    public string AbilityName { get => _abilityName; }

    //Alows classes to access the values of the ability discription
    public string AbilityDiscription { get => _abilityDiscription; }

    //Alows classes to access the values as well as augmenting it of the ability under cooldown  
    public bool IsUnderCooldown { get => _isUnderCooldown; set => _isUnderCooldown = value; }

    //Alows classes to access the values of the ability damage 
    public float AbilityDamage { get => _abilityDamage; }

    //Alows classes to access the values of the ability coooldown 
    public float AbilityCooldown { get => _abilityCooldown; }

}
