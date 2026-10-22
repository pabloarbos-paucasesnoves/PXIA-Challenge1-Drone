using System;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField]
    private float _timeToSelfDestruct = 4f;
    
    private void Start()
    {
        Destroy(gameObject, _timeToSelfDestruct);
    }
}
