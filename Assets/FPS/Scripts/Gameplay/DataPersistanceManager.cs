using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistanceManager : MonoBehaviour
{
    private GameData gameData;

    public static DataPersistanceManager instance { get; private set; }

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("There are more than one Data Persistance Managers in the scene!");
        }
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        this.gameData = new GameData();
    }

    public void SaveGame()
    {
    }

    public void LoadGame()
    {
        if (this.gameData == null)
        {
            Debug.Log("There is no existing save! Loading new game.");
            NewGame();
        }
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
}
