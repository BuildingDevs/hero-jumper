using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour, IDataPersistance
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

    public void LoadData(GameData data)
    {
        this.currentLevel = data.currentLevel;
    }

    public void SaveData(GameData data)
    {
        data.currentLevel = this.currentLevel;
    }

    public void LoadNextLevel()
    {
        currentLevel++;
        DataPersistanceManager.instance.SaveGame();
        SceneManager.LoadScene(currentLevel);
    }
}
