using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEngine.SceneManagement.Scene;

public class PauseScript : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Func()
    {
        Debug.Log("HI!");
    }
}
