using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartLogic : MonoBehaviour
{
    public static int newMax;
    [SerializeField] Text maxNumber;
    float max = 1000;

    // Start is called before the first frame update
    void Start()
    {
        newMax = 1000;
        maxNumber.text = max.ToString();
    }

    public void OnvalueChanged(float newValue)
    {
        max = newValue;
        maxNumber.text = max.ToString();
        newMax = (int)max;
    }
}
