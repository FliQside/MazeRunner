using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    // Change scene to start screen
    // Pre: Cannot already be on start screen
    // Post: Displays Start Screen
    public void ToStartScreen()
    {
        SceneManager.LoadScene("StartScreen");
    }



}
