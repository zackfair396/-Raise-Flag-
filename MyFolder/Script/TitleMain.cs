using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMain : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject m_goGameSelectWindow;
    public GameObject m_goQuestWindow;
    public GameObject LoadGame_1v1;
    public GameObject LoadGame_2v2;

    //ゲームオブジェクトメソッド“m_goQuestWindow”の宣言

    public void ButtonPushed()
    {
        SceneManager.LoadScene("GameScenes1v1");
        Debug.Log("ボタンが押されました");
    }
        
    public void ButtonPushed2v2()
    {
        SceneManager.LoadScene("GameScenes2v2");
    }

    public void OpenQuestWindow()
        //クエストウインドウを開くためのメソッド宣言
    {
        m_goQuestWindow.SetActive(true);
        //インスペクターでセットしたゲームオブジェクトメソッド“m_goQuestWindow”を有効にする。
        Debug.Log("クエスト画面");
    }

    public void CloseQuestWindow()
    {
        m_goQuestWindow.SetActive(false);
    }

    public void OpenGameSelect()
    {
        m_goGameSelectWindow.SetActive(true);
        Debug.Log("難易度選択");
    }

    public void CloseGameWindouw()
    {
        m_goGameSelectWindow.SetActive(false);
        
    }

    public void OpenLoadGame()
    {
        
        LoadGame_1v1.SetActive(true);

        Debug.Log("1v1をプレイしますか？");

    }

    public void CloseLoadGame()
    {
        LoadGame_1v1.SetActive(false);
    }

    public void OpenLoadGame_2v2()
    {
        
    }

    public void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
