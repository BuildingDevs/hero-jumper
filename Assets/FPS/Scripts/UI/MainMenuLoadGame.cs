using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuLoadGame : MonoBehaviour
{
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
    }

    public void NewGameButton()
    {
        DataPersistanceManager.instance.NewGame();
    }
}
