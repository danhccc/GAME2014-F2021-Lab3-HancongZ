using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonBehaviours : MonoBehaviour
{
    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene("Start");
    }
}
