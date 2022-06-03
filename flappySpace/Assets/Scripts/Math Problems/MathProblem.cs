using UnityEngine;

public class MathProblem : MonoBehaviour
{
    private int _numberA, _numberB, _equation, _problem;

    public void Start()
    {
        GenerateRandomNumber();
        PrintProblem();
    }

    // prints the equation problem before the wall objects
    public void PrintProblem()
    {
        switch (_equation)
        {
            case 1:
                GetComponent<TextMesh>().text = "" + _numberA + " + " + _numberB;
                break;
            case 2:
                GetComponent<TextMesh>().text = "" + _numberA + " - " + _numberB;
                break;
            default:
                GetComponent<TextMesh>().text = "error";
                break;
        }
    }

    // Randomly create a problem 
    public int GetProblem()
    {
        Debug.Log($"this is the case number: {_equation}");
        switch (_equation)
        {
            case 1:
                _problem = _numberA + _numberB;
                break;

            case 2:
                _problem = _numberA - _numberB;
                break;

            default:
                _problem = _numberA + _numberB;
                break;
        }
        Debug.Log($"this is the problem: {_problem}");
        return _problem;
    }

    // Randomize numbers for problem creation
    public void GenerateRandomNumber()
    {
        Debug.Log($"our random numbers");

        _numberA = Random.Range(1, 20);
        _numberB = Random.Range(1, 20);
        _equation = Random.Range(1, 3);
    }
}