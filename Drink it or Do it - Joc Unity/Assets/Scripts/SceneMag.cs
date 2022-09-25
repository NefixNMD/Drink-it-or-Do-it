using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMag : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayTheGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2, LoadSceneMode.Single);
    }
}
