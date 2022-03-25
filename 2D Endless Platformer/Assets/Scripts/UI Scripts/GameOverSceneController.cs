using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneController : MonoBehaviour
{

    // Go to Game Scene
	public void LoadMainScene(){
		SceneManager.LoadScene("Main");
	}

    // Go to Menu Scene
    public void LoadMenuScene(){
		SceneManager.LoadScene("Menu");
	}

}
