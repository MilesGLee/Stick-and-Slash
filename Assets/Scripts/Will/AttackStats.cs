using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class AttackStats : ScriptableObject
{
    public string AbilityName = "defult";
    public string AbilityDiscription = "None";
    public float AbilityDamage = 0.0f;
}
