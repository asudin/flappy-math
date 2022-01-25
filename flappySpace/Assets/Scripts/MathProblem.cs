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
                if (numberA > numberB)
                {
                    problem = numberA - numberB;
                }
                else if (numberA < numberB)
                {
                    int numberC = numberB;
                    numberA = numberB;
                    numberB = numberC;
                    problem = numberA - numberB;
                }
                break;
            default:
                problem = 999;
                break;
        }
        Debug.Log($"this is the problem: {problem}");
        return problem;
    }
    public void GenerateRandomNumber()
    {
        Debug.Log($"erorr in GenNumb");
        numberA = Random.Range(1, 20);
        numberB = Random.Range(1, 20);
        equation = Random.Range(1, 3);
    }
}
