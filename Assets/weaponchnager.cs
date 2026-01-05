using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponchnager : MonoBehaviour
{
    public weapon weapon;
    void Start()
    {
        
    }
    void Update()
    {
        transform.RotateAround(
            Vector3.zero, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
    
}
