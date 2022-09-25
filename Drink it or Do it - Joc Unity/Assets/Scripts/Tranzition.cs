using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tranzition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForSeconds());
    }
   public static IEnumerator WaitForSeconds(){
       yield return new WaitForSeconds(5);
       SceneManager.LoadScene(sceneBuildIndex: 1, LoadSceneMode.Single);
    }
}
