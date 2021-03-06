using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{
    public CanvasRenderer startButtonRenderer;
    public GameObject optionsPanel;

    public AudioSource selectSound;
    public AudioSource closeSound;

    public void OnStartButton_Pressed()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void OnLvl2Btn_Pressed()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void OnLvl3Btn_Pressed()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void OnCloseButton_Pressed()
    {
        optionsPanel.SetActive(false);
        closeSound.Play();
    }

    public void OnOptionsButton_Pressed()
    {
        optionsPanel.SetActive(true);
        selectSound.Play();
    }

    public void OnStartButton_Over()
    {
        startButtonRenderer.SetAlpha(0.7f);
    }

    public void OnStartButton_Out()
    {
        startButtonRenderer.SetAlpha(1.0f);
    }
}
