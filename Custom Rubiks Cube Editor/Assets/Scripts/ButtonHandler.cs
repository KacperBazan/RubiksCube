using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    ColorManager cm;
    ReadCube rc;
    SolveCube solveCube;
    public Color Ncolor;

    private void Start()
    {
        Ncolor = GetComponent<Button>().colors.normalColor; //Normal color of button (Not pressed/highlighted/selected)
        cm = FindObjectOfType<ColorManager>();
        rc = FindObjectOfType<ReadCube>();
        solveCube = FindObjectOfType<SolveCube>();
    }

    //Called whenever a button is clicked. Changes the color in ColorManager.
    //Thus, when the two bools in ColorManager are true, the selectedObject changes colors
    //to the color saved from the buttons.
    public void SetColor()
    {
        cm.color.r = Ncolor.r;
        cm.color.g = Ncolor.g;
        cm.color.b = Ncolor.b;
        cm.color.a = Ncolor.a;
    }

    public void CallSolve()
    {
        solveCube.Solver();
    }

    public void CallReColor()
    {
        rc.ReColor();
    }
}
