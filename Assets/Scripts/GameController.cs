using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
   [System.Serializable]

public class GameController : MonoBehaviour
{
    public GameObject cView;
    private Text consoleView;
    void Start()
    {
       consoleView = cView.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
          //  Debug.Log("Test");
          //consoleView.text = "Words From Script";
    }
}
