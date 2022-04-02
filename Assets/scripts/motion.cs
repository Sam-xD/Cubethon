using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{

    public Transform a;
    public Vector3 offset;
    // Start is called before the first frame update
 
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(a.position);
        transform.position = a.position + offset;

    }
}
