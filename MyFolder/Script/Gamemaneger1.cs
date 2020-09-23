using System.Collections;
using System.Collections.Generic;
using TbsFramework.Grid;
using TbsFramework.Grid.GridStates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemaneger1 : MonoBehaviour
{

    public GameObject TitleBack;
    public GameObject Continue;

    public void ButtonPush1()
    {
        SceneManager.LoadScene("GameScenes1v1");


    }

    public void ButtonPush2()
    {
        SceneManager.LoadScene("StartScene");
        Debug.Log("ボタンが押された");

    }

    public CellGrid CellGrid;
    public void turnend()
    {
        if ( !(CellGrid.CellGridState is CellGridStateAiTurn))
        {
            CellGrid.EndTurn();//User ends his turn by pressing "n" on keyboard.
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
