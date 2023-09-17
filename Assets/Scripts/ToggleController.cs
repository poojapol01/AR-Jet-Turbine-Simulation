using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleController : MonoBehaviour
{
    public GameObject turbineObject;
    private bool isActive = true;

    public void Toggle()
    {
        if (isActive)
        {
            turbineObject.SetActive(false);
            isActive = false;
        }
        else
        {
            turbineObject.SetActive(true);
            isActive =  true;
        }
    }
}
