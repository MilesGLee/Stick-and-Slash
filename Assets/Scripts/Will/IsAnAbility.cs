using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAnAbility : MonoBehaviour
{
    [SerializeField]
    private AttackStats _attack;

    public AttackStats Attack { get => _attack; }
}
