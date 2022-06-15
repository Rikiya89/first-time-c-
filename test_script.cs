using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script : MonoBehaviour
{   
    int testIntNum;
    float testFloatNum;
    string testString;
    bool testFlag;

    public int publicTestIntNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        //print("はじめに一回だけ出力されるよ");

        //testIntNum = 1;
        //testFloatNum = 1.5f;
        //testString = "c#始めました";
        //testFlag = false;

        //print(testIntNum);
        //print(testFloatNum );
        //print(testString);
        //print(testFlag);
        if (publicTestIntNum > 1)
        {
            print("1より大きいよ");
        }
        else
        {
            print("1より小さいよ");
        }
            }

    // Update is called once per frame
    void Update()
    {
        if (testFlag == false)
        {
            print(testString);
            testFlag = true;
        }
    }
}
