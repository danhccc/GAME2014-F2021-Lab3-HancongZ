using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehaviours : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }

}
