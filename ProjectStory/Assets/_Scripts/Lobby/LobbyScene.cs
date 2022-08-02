using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyScene : MessageListener
{
    public Button NewGame, LoadGame, ExitGame;

    protected override void AddMessageListener()
    {
        base.AddMessageListener();

        NewGame.onClick.AddListener(StartNewGame);
        LoadGame.onClick.AddListener(StartLoadGame);
        ExitGame.onClick.AddListener(QuitGame);
    }

    protected override void OnMessage(MessageID msgID, object sender, object data)
    {
        base.OnMessage(msgID, sender, data);
    }

    void StartNewGame()
    {
        //캐릭터 선택 팝업
        SendMessage(MessageID.Call_UI_Push_Popup, String_UIName.SelectCharacter);
    }

    void StartLoadGame()
    {
        Debug.Log("로드 게임");
    }

    void QuitGame()
    {
        Debug.Log("게임 종료");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
