
using UnityEngine;
using UnityEngine.SceneManagement;

public class trig : MonoBehaviour
{
    void OnTriggerEnter()
    {
        //Debug.Log("trigger");
        FindObjectOfType<GameManager>().Ui();       

    }
}
  
