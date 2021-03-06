using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuLoadGame : MonoBehaviour, IDataPersistance
{
    private int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameButton()
    {
        DataPersistanceManager.instance.LoadGame();
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void NewGameButton()
    {
        DataPersistanceManager.instance.NewGame();
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentLevel + 1);
    }

    public void LoadData(GameData data)
    {
        this.currentLevel = data.currentLevel;
    }

    public void SaveData(GameData data)
    {
        data.currentLevel = this.currentLevel;
    }
}
