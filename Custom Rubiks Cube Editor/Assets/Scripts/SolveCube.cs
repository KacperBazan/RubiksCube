using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kociemba;

public class SolveCube : MonoBehaviour
{
    private Color white = new Color(1f, 1f, 1f, 1f); //Up
    private Color blue = new Color(0f, 0f, 1f, 1f); //Right
    private Color red = new Color(1f, 0f, 0f, 1f); //Front
    private Color yellow = new Color(1f, 1f, 0f, 1f); //Down
    private Color green = new Color(0f, 1f, 0f, 1f); //Left
    private Color orange = new Color(1f, 0.5f, 0f, 1f); //Back

    CubeState cubeState;

    void Start()
    {
        cubeState = FindObjectOfType<CubeState>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Solver();
        }
    }

    public void Solver()
    {
        string stateString = GetString();
        string info = "";
        //print("Cube State: " + stateString);

        //First time building tables.
        //string solution = SearchRunTime.solution(stateString, out info, buildTables: true);

        //Every other time once tables are built.
        string solution = Search.solution(stateString, out info);

        List<string> solutionList = StringToList(solution);

        if (info != "")
        {
            print("Info: " + info);
        }
        else
        {
            print("Info: None");
        }

        if (solution != "")
        {
            print("Solution String: " + solution);
        }
    }

    List<string> StringToList(string s)
    {
        List<string> solutionList = new List<string>(s.Split(new string[] { " " }, System.StringSplitOptions.RemoveEmptyEntries));
        return solutionList;
    }


    string GetString()
    {
        string mainString = "";
        var facesColor = cubeState.facesColor;

        for (int i = 0; i <= 5; i++)
        {
            for (int j = 0; j <= 8; j++)
            {
                if (facesColor[i][j] == white)
                {
                    mainString += "U";
                    continue;
                }
                if (facesColor[i][j] == blue)
                {
                    mainString += "R";
                    continue;
                }
                if (facesColor[i][j] == red)
                {
                    mainString += "F";
                    continue;
                }
                if (facesColor[i][j] == yellow)
                {
                    mainString += "D";
                    continue;
                }
                if (facesColor[i][j] == green)
                {
                    mainString += "L";
                    continue;
                }
                if (facesColor[i][j] == orange)
                {
                    mainString += "B";
                    continue;
                }
                else
                {
                    mainString = "MISSING COLORS";
                    return mainString;
                }
            }
        }
        return mainString;
    }
}
