using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviours : MonoBehaviour
{
    private int nextSceneIndex;
    private int previousSceneIndex;

    private void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
    }

    // NextButton pressed event handler
    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }

    // BackButton pressed event handler
    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(previousSceneIndex);
    }
}
