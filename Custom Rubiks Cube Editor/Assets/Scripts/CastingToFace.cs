using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingToFace : MonoBehaviour
{
    public GameObject selectedObject;
    public RaycastHit theObject;
    private int layermask = 1 << 8;

    void Update()
    {
        //Sends a raycast to wherever the mouse cursor is on the screen.
        //If the mouse cursor hovers over an object, selectedObject is populated.
        //Else, selectedObject is empty.

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out theObject,Mathf.Infinity, layermask))
        {
            selectedObject = theObject.transform.gameObject;
        }
        else
        {
            selectedObject = null;
        }
    }
}
