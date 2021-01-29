using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeState : MonoBehaviour
{
    //GameObjects
    private List<GameObject> up = new List<GameObject>();
    private List<GameObject> right = new List<GameObject>();
    private List<GameObject> front = new List<GameObject>();
    private List<GameObject> down = new List<GameObject>();
    private List<GameObject> left = new List<GameObject>();
    private List<GameObject> back = new List<GameObject>();

    public List<List<GameObject>> faces = new List<List<GameObject>>();

    //Colors
    private List<Color> upColor = new List<Color>();
    private List<Color> rightColor = new List<Color>();
    private List<Color> frontColor = new List<Color>();
    private List<Color> downColor = new List<Color>();
    private List<Color> leftColor = new List<Color>();
    private List<Color> backColor = new List<Color>();

    public List<List<Color>> facesColor = new List<List<Color>>();

    //Default Colors
    public List<List<Color>> defaultColors = new List<List<Color>>();


    void Start()
    {
        faces.Add(up);
        faces.Add(right);
        faces.Add(front);
        faces.Add(down);
        faces.Add(left);
        faces.Add(back);

        facesColor.Add(upColor);
        facesColor.Add(rightColor);
        facesColor.Add(frontColor);
        facesColor.Add(downColor);
        facesColor.Add(leftColor);
        facesColor.Add(backColor);

        for (int i = 0; i <= 5; i++)
        {
            defaultColors.Add(new List<Color>());
        }
            
    }
}
