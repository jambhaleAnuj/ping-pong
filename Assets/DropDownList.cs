using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDownList : MonoBehaviour
{

    float a;
    public void SpeedLevel(int val)
    {
        switch (val)
        {
            case 0:
                a = 5f;
                //PlayerPrefs.SetFloat("SetSpeed", 5f);
                break;

            case 1:
                a = 4f;
                //PlayerPrefs.SetFloat("SetSpeed", 7f);
                break;

            case 2:
                a = 3f;

                //PlayerPrefs.SetFloat("SetSpeed", 13);
                break;

            case 3:
                //PlayerPrefs.SetFloat("SetSpeed", 16);
                break;

            case 4:
                //PlayerPrefs.SetFloat("SetSpeed", 19);
                break;

            case 5:
                //PlayerPrefs.SetFloat("SetSpeed", 22);
                break;

            case 6:
                //PlayerPrefs.SetFloat("SetSpeed", 25);
                break;

            case 7:
                Debug.Log("8");
                break;

            case 8:
                Debug.Log("9");
                break;

        }
        PlayerPrefs.SetFloat("SetSpeed", a);
    }
}
