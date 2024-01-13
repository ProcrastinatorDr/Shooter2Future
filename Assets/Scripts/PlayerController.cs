using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    private Vector3 directionVector;
    public void OnMove(InputValue value)
    {
        directionVector = (Vector3)value.Get<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * directionVector);
    }
}
