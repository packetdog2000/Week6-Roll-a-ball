using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPMovement : MonoBehaviour
{

    public Vector3 direction;
    public  float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        
    }

    public void OnPlayerMove(InputValue value)
    {
        Vector2 inputVector = value.Get<Vector2>();
        direction = new Vector3(inputVector.x, direction.y, 0);

        direction.x = inputVector.x;
        direction.z = inputVector.y;
    }
}
