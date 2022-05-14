using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuLevelText : MonoBehaviour, IDataPersistance
{
    public TextMeshProUGUI currentLevelText;

    private int currentLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentLevelText.text = "Level " + currentLevel;
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
        //data.currentLevel = this.currentLevel;
    }
}
