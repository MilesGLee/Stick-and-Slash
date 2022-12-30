using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class AttackStats : ScriptableObject
{
    //The name of this ability 
    [Tooltip("The name of this ability ")]
    public string AbilityName = "defult";

    [Tooltip("For short discrptive discription of the ability maybe even lore")]
    public string AbilityDiscription = "None";

    [Tooltip("Ability physical")]
    public GameObject AbilityArt;

    [Tooltip("Current ability damage out put")]
    public float AbilityDamage = 0.0f;
}
