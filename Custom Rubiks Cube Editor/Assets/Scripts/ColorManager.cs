using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public Color color;
    CastingToFace cast;
    ReadCube readCube;

    private void Start()
    {
        cast = FindObjectOfType<CastingToFace>();
        readCube = FindObjectOfType<ReadCube>();
        color = new Color32(255, 255, 255, 255); //Defaults the color to white.
    }

    private void Update()
    {
        //If clicking and you are hovering over an object, the selectedObject changes color.
        if (Input.GetMouseButtonDown(0) && cast.selectedObject != null)
        {
            cast.selectedObject.GetComponent<Renderer>().material.color = color;
            readCube.UpdateColors(); //Updates color array in readCube every click
        }
    }

}
