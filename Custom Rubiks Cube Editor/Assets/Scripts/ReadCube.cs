using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadCube : MonoBehaviour
{
    public Transform tUp;
    public Transform tRight;
    public Transform tFront;
    public Transform tDown;
    public Transform tLeft;
    public Transform tBack;

    CubeState cubestate;
    private int facelayerMask = 1 << 8;
    private int centerlayerMask = 1 << 9;

    private void Start()
    {
        cubestate = FindObjectOfType<CubeState>();
        UpdateCube();
    }

    private void UpdateCube()
    {
        var faces = cubestate.faces;
        var facesColor = cubestate.facesColor;
        var defaultColors = cubestate.defaultColors;
        int counter = 0;

        //Raycasts from each ray origin position and adds the GameObjects and Colors to seperate lists after colliding with pieces.
        foreach (Transform rayOrigin in transform)
        {
            for (int y = 1; y > -2; y--)
            {
                for (int x = -1; x < 2; x++)
                {
                    Vector3 dir = rayOrigin.position + (x * rayOrigin.right) + (y * rayOrigin.up) + (2.5f * rayOrigin.forward);
                    RaycastHit raycastHit;
                    if (Physics.Raycast(rayOrigin.position, dir, out raycastHit, (facelayerMask | centerlayerMask)))
                    {
                        faces[counter].Add(raycastHit.collider.gameObject);
                        facesColor[counter].Add(raycastHit.collider.gameObject.GetComponent<Renderer>().material.color);
                        defaultColors[counter].Add(raycastHit.collider.gameObject.GetComponent<Renderer>().material.color);
                    }
                }
            }
            counter++;
        }
    }

    //Looks at GameObjects already stored in faces[][] and updates the colors in facesColor[][] to match.
    public void UpdateColors()
    {
        var faces = cubestate.faces;
        var facesColor = cubestate.facesColor;

        for (int i = 0; i <= 5; i++)
        {
            for (int j = 0; j <= 8; j++)
            {
                facesColor[i][j] = faces[i][j].GetComponent<Renderer>().material.color;
            }
        }
    }

    public void ReColor()
    {
        var faces = cubestate.faces;
        var defaultColors = cubestate.defaultColors;

        for (int i = 0; i <= 5; i++)
        {
            for (int j = 0; j <= 8; j++)
            {
                faces[i][j].GetComponent<Renderer>().material.color = defaultColors[i][j];
            }
        }
    }


}
