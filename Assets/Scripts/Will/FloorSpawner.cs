using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void MyDelegate();

public class FloorSpawner : MonoBehaviour
{
    [SerializeField]
    //Floors ready to be spawned in the scene 
    private GameObject[] _floor;

    [SerializeField]
    //Current floor in the scene
    private GameObject _currentFloor = null;

    [SerializeField]
    int _floorIndex = 0;

    MyDelegate _spawnFloor;


    private void Awake()
    {
        if (_currentFloor == null)
        {
            _currentFloor = _currentFloor = Instantiate(_floor[_floorIndex], transform);
            return;
        }
    }

    public void SpawnFloor()
    {
        _floorIndex++;

        if (_currentFloor && _floor.Length > 0 && _floorIndex < _floor.Length)
        {
            Destroy(_currentFloor, .5f);
            _currentFloor = Instantiate(_floor[_floorIndex], transform);
        }
    }
}
