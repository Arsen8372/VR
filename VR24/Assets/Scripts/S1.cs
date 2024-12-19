using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class S1 : MonoBehaviour
{

    public GameObject test;
    void FixedUptade()
    {

    }
    public void ClickButton()
    {
        test.SetActive(!(test.activeSelf));
    }
}