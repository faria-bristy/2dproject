using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private int rotationSpeed = 200;
    void Start()
    {
        

    }
    void Update()
    {
        transform.RotateAround(
            Vector3.zero, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}