using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractions : MonoBehaviour
{
    Vector3 moveVal;
    [SerializeField] float moveSpeed;

    public void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector3>();
    }

    void Update()
    {
        transform.Translate(new Vector3(moveVal.x, 0, moveVal.z) * moveSpeed * Time.deltaTime);
    }
}
