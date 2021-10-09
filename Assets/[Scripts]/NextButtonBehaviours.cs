using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonBehaviours : MonoBehaviour
{
    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene("End");
    }
}
