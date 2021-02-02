using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using UnityEngine;

public class NumberGen : MonoBehaviour
{
    public Text[] gridOneAr = new Text[9];
    public Text[] gridTwoAr = new Text[9];
    public Text[] gridThreeAr = new Text[9];
    public Text[] gridFourAr = new Text[9];
    public Text[] gridFiveAr = new Text[9];
    public Text[] gridSixAr = new Text[9];
    public Text[] gridSevenAr = new Text[9];
    public Text[] gridEightAr = new Text[9];
    public Text[] gridNineAr = new Text[9];

    public int[] topRow = new int[9];

    void Start()
    {
        gridOne();
        gridTwo();
        gridThree();
        gridFour();
        gridFive();
        gridSix();
        gridSeven();
        gridEight();
        gridNine();
    }

    public void gridOne()
    {
        int[] numberRange = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] finalNumberArray = new int[10];
        int p = -1;

        for (int i = 0; i < 100; i++)
        {
            if (numberRange != null)
            {
                int randomNum = Random.Range(0, 10); //create random num
                if (numberRange.Contains(randomNum)) //see if array contains that number, 
                {
                    p++;
                    numberRange = numberRange.Where(e => e != randomNum).ToArray(); //if it does, remove it
                    finalNumberArray[p] = randomNum;
                    //Debug.Log(string.Join(" ", numberRange) + "  Removed  " + randomNum);
                    //Debug.Log(string.Join(" ", finalNumberArray));
                }
            }
        }
        for (int i = 0; i < 9; i++)
        {
            gridOneAr[i].text = finalNumberArray[i].ToString(); //assign each text object in the grid array to each spot in the text array
        }
    }

    public void gridTwo()
    {
        int[] numberRange = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] finalNumberArray = new int[10];
        int p = -1;

        for (int i = 0; i < 100; i++)
        {
            if (numberRange != null)
            {
                int randomNum = Random.Range(0, 10); //create random num
                if (numberRange.Contains(randomNum)) //see if array contains that number
                {
                    p++;
                    numberRange = numberRange.Where(e => e != randomNum).ToArray(); //if it does, remove it
                    finalNumberArray[p] = randomNum;
                    //Debug.Log(string.Join(" ", numberRange) + "  Removed  " + randomNum);
                    //Debug.Log(string.Join(" ", finalNumberArray));
                }
            }
        }
        for (int i = 0; i < 9; i++)
        {
            gridTwoAr[i].text = finalNumberArray[i].ToString(); //assign each text object in the grid array to each spot in the text array
        }
    }

    public void gridThree()
    {
        int[] numberRange = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] finalNumberArray = new int[10];
        int p = -1;

        for (int i = 0; i < 100; i++)
        {
            if (numberRange != null)
            {
                int randomNum = Random.Range(0, 10); //create random num
                if (numberRange.Contains(randomNum)) //see if array contains that number
                {
                    p++;
                    numberRange = numberRange.Where(e => e != randomNum).ToArray(); //if it does, remove it
                    finalNumberArray[p] = randomNum;
                    //Debug.Log(string.Join(" ", numberRange) + "  Removed  " + randomNum);
                    //Debug.Log(string.Join(" ", finalNumberArray));
                }
            }
        }
        for (int i = 0; i < 9; i++)
        {
            gridThreeAr[i].text = finalNumberArray[i].ToString(); //assign each text object in the grid array to each spot in the text array
        }
    }

    public void gridFour()
    {
        int[] numberRange = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] finalNumberArray = new int[10];
        int p = -1;

        for (int i = 0; i < 100; i++)
        {
            if (numberRange != null)
            {
                int randomNum = Random.Range(0, 10); //create random num
                if (numberRange.Contains(randomNum)) //see if array contains that number
                {
                    p++;
                    numberRange = numberRange.Where(e => e != randomNum).ToArray(); //if it does, remove it
                    finalNumberArray[p] = randomNum;
                    //Debug.Log(string.Join(" ", numberRange) + "  Removed  " + randomNum);
                    //Debug.Log(string.Join(" ", finalNumberArray));
                }
            }
        }
        for (int i = 0; i < 9; i++)
        {
            gridFourAr[i].text = finalNumberArray[i].ToString(); //assign each text object in the grid array to each spot in the text array
        }
    }

    public void gridFive()
    {
        int[] numberRange = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] finalNumberArray = new int[10];
        int p = -1;

        for (int i = 0; i < 100; i++)
        {
            if (numberRange != null)
            {
                int randomNum = Random.Range(0, 10); //create random num
                if (numberRange.Contains(randomNum)) //see if array contains that number
                {
                    p++;
                    numberRange = numberRange.Where(e => e != randomNum).ToArray(); //if it does, remove it
                    finalNumberArray[p] = randomNum;
                    //Debug.Log(string.Join(" ", numberRange) + "  Removed  " + randomNum);
                    //Debug.Log(string.Join(" ", finalNumberArray));
                }
            }
        }
        for (int i = 0; i < 9; i++)
        {
            gridFiveAr[i].text = finalNumberArray[i].ToString(); //assign each text object in the grid array to each spot in the text array
        }
    }

    public void gridSix()
    {
        int[] numberRange = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] finalNumberArray = new int[10];
        int p = -1;

        for (int i = 0; i < 100; i++)
        {
            if (numberRange != null)
            {
                int randomNum = Random.Range(0, 10); //create random num
                if (numberRange.Contains(randomNum)) //see if array contains that number
                {
                    p++;
                    numberRange = numberRange.Where(e => e != randomNum).ToArray(); //if it does, remove it
                    finalNumberArray[p] = randomNum;
                    //Debug.Log(string.Join(" ", numberRange) + "  Removed  " + randomNum);
                    //Debug.Log(string.Join(" ", finalNumberArray));
                }
            }
        }
        for (int i = 0; i < 9; i++)
        {
            gridSixAr[i].text = finalNumberArray[i].ToString(); //assign each text object in the grid array to each spot in the text array
        }
    }

    public void gridSeven()
    {
        int[] numberRange = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] finalNumberArray = new int[10];
        int p = -1;

        for (int i = 0; i < 100; i++)
        {
            if (numberRange != null)
            {
                int randomNum = Random.Range(0, 10); //create random num
                if (numberRange.Contains(randomNum)) //see if array contains that number
                {
                    p++;
                    numberRange = numberRange.Where(e => e != randomNum).ToArray(); //if it does, remove it
                    finalNumberArray[p] = randomNum;
                    //Debug.Log(string.Join(" ", numberRange) + "  Removed  " + randomNum);
                    //Debug.Log(string.Join(" ", finalNumberArray));
                }
            }
        }
        for (int i = 0; i < 9; i++)
        {
            gridSevenAr[i].text = finalNumberArray[i].ToString(); //assign each text object in the grid array to each spot in the text array
        }
    }

    public void gridEight()
    {
        int[] numberRange = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] finalNumberArray = new int[10];
        int p = -1;

        for (int i = 0; i < 100; i++)
        {
            if (numberRange != null)
            {
                int randomNum = Random.Range(0, 10); //create random num
                if (numberRange.Contains(randomNum)) //see if array contains that number
                {
                    p++;
                    numberRange = numberRange.Where(e => e != randomNum).ToArray(); //if it does, remove it
                    finalNumberArray[p] = randomNum;
                    //Debug.Log(string.Join(" ", numberRange) + "  Removed  " + randomNum);
                    //Debug.Log(string.Join(" ", finalNumberArray));
                }
            }
        }
        for (int i = 0; i < 9; i++)
        {
            gridEightAr[i].text = finalNumberArray[i].ToString(); //assign each text object in the grid array to each spot in the text array
        }
    }

    public void gridNine()
    {
        int[] numberRange = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] finalNumberArray = new int[10];
        int p = -1;

        for (int i = 0; i < 100; i++)
        {
            if (numberRange != null)
            {
                int randomNum = Random.Range(0, 10); //create random num
                if (numberRange.Contains(randomNum)) //see if array contains that number
                {
                    p++;
                    numberRange = numberRange.Where(e => e != randomNum).ToArray(); //if it does, remove it
                    finalNumberArray[p] = randomNum;
                    //Debug.Log(string.Join(" ", numberRange) + "  Removed  " + randomNum);
                    //Debug.Log(string.Join(" ", finalNumberArray));
                }
            }
        }
        for (int i = 0; i < 9; i++)
        {
            gridNineAr[i].text = finalNumberArray[i].ToString(); //assign each text object in the grid array to each spot in the text array
        }
    }
}
