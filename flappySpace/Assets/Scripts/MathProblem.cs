using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MathProblem : MonoBehaviour
{
    private int numberA, numberB, equation;

    public void Start()
    {
        GenerateRandomNumber();
        PrintProblem();
    }

    // prints the equation problem before the wall objects
    public void PrintProblem()
    {
        switch (equation)
        {
            case 1:
                GetComponent<TextMesh>().text = "" + numberA + " + " + numberB;
                break;
            case 2:
                if (numberA > numberB)
                {
                    GetComponent<TextMesh>().text = "" + numberA + " - " + numberB;
                }
                else if (numberA < numberB)
                {
                    GetComponent<TextMesh>().text = "" + numberA + " - " + numberB;
                }
                break;
            default:
                GetComponent<TextMesh>().text = "error";
                break;
        }
    }

    // randomly produces an equation 
    public int GetProblem()
    {
        int problem = 0;
        Debug.Log($"this is the case number: {equation}");
        switch (equation)
        {
            case 1:
                problem = numberA + numberB;
                break;
            case 2:
                problem = numberA - numberB;
                break;
            default:
                problem = 999;
                break;
        }
        Debug.Log($"this is the problem: {problem}");
        return problem;
    }

    // randomizes the numbers
    public void GenerateRandomNumber()
    {
        Debug.Log($"our random numbers");
        numberA = Random.Range(1, 20);
        numberB = Random.Range(1, 20);
        equation = Random.Range(1, 3);
    }
}