using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string saveString = PlayerPrefs.GetString("Save_Data", "No_Data");

        Debug.Log(saveString);

        PlayerPrefs.SetString("Save_Data", "Have_Data");

        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
