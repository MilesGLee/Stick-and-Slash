using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityContainer : MonoBehaviour
{
    static private GameObject _abilityOne;
    static private GameObject _abilityTwo;
    static private GameObject _abilityThree;

    public AbilityContainer[] abilityContainers;



    static void Restarting()
    {
        _abilityOne = new GameObject();
        _abilityTwo = new GameObject();
        _abilityThree = new GameObject();
    }
}
