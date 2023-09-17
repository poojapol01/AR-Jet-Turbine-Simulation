using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public Vector3 rotationValue;

    private void Update()
    {
        transform.Rotate(rotationValue * Time.deltaTime);
    }
}
