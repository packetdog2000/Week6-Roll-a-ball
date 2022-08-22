using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Controls")]

    [Tooltip("The speed at which the collectible rotates")]
    [SerializeField]
    private float rotationSpeed;

    [Tooltip("The rotation axis (X,Y,Z) of the collectibles are rotating")]
    [SerializeField]
    private Vector3 rotationAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);
    }
}
