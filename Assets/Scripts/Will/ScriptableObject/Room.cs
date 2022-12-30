using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : ScriptableObject
{
    [Tooltip("The room being spawned when created "), SerializeField]
    private GameObject _theRoom;

    [Tooltip("The enemies being spawned"), SerializeField]
    private GameObject[] _enemiesInTheRoom;
}
