using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class S2 : MonoBehaviour
{
    public int number = 5;
    public Text Mytxt;
    void FixedUpdate()
    {
    }
    public void OnCollisionEnter(Collision collision)
    {
        number--;
        Mytxt.text = number.ToString();
    }
}
