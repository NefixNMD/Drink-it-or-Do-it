using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePreferanceManager : MonoBehaviour
{
    public CardPlay addon;
    private const string ScoreKey = "On";
    // Start is called before the first frame update
    void Start()
    {
        SavePrefs();
    }
    void Update(){
        
        LoadPrefs();
    }

    public void LoadPrefs()
    {
        PlayerPrefs.SetInt(ScoreKey,addon.ads);
        PlayerPrefs.Save();
    }
    public void SavePrefs()
    {
        var score = PlayerPrefs.GetInt(ScoreKey,0);
        addon.ads = score;

    }
}
