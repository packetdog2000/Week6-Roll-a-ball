using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPCamera : MonoBehaviour
{

    public Camera playerCamera;

    public float deltaX;
    public float deltaY;

    public float xRot;
    public float yRot;



    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main;
        Cursor.visible = false; // hide cursor

    }

    // Update is called once per frame
    void Update()
    {
        yRot += deltaX;
        xRot = deltaY;

        xRot = Mathf.Clamp(xRot, -90f, 90f);

        playerCamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        transform.rotation = Quaternion.Euler(0,yRot, 0);
    }

    public void OnCameraLook(InputValue value)
    {
        Vector2 InputVector = value.Get<Vector2>();
        deltaX = InputVector.x;
        deltaY = InputVector.y;
    }
}
