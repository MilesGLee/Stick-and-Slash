using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityContainer : MonoBehaviour
{
    private AbilityContainer _abilityOne;
    private AbilityContainer _abilityTwo;
    private AbilityContainer _abilityThree;

    public AbilityContainer[] abilityContainers;



    void Restarting()
    {
        _abilityOne = new AbilityContainer();
        _abilityTwo = new AbilityContainer();
        _abilityThree = new AbilityContainer();
    }
}
