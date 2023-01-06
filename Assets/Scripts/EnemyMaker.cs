using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMaker : MonoBehaviour
{
    [SerializeField] private float _startTime;
    public GameObject enemy;
    public Transform spownPoint;

    private float _timeBetweenSpowns = 6;
    private float _totalGameTime;

    void Start()
    {
        _totalGameTime = _timeBetweenSpowns - _startTime;
    }

    void Update()
    {
        if(_totalGameTime >= _timeBetweenSpowns) 
        {
            Instantiate(enemy, spownPoint.transform.position, Quaternion.identity);
            _totalGameTime = 0;
        }
        else 
        {
            _totalGameTime += Time.deltaTime;
        }
    }
}
