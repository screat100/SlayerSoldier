﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void GoToStage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void GoToStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void GoToStage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void GoToStage4()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void GoToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void GoToSelectStage()
    {
        SceneManager.LoadScene("SelectStage");
    }

    public void GoToTestSampleScene1()
    {
        SceneManager.LoadScene("SampleScene1");
    }
}
