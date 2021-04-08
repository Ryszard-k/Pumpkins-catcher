using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_exit : MonoBehaviour
{

    public void exit()
    {
        Debug.Log("Yolo");
        Application.Quit();
    }

    public void StartAgain()
	{
		Debug.Log("start");
		SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
		SceneManager.LoadScene("SampleScene");
	}
}
