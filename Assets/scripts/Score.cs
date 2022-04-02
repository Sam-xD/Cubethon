using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform tr;
    public Text sc;
 

    // Update is called once per frame
    void Update()
    {
        sc.text=(tr.position.z+28.9).ToString("0");

    }
}
