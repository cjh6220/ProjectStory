using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SelectCharacterPopup : MessageListener
{
    public Button LeftButton, RightButton, StartButton;
    public GameObject Obj;
    public Transform CharacterPivot;
    int _currentInx = 0, _maxCount = 0;

    protected override void AddMessageListener()
    {
        base.AddMessageListener();

        LeftButton.onClick.AddListener(OnClickLeftButton);
        RightButton.onClick.AddListener(OnClickRightButton);
        StartButton.onClick.AddListener(OnClickStart);
    }

    protected override void OnMessage(MessageID msgID, object sender, object data)
    {
        base.OnMessage(msgID, sender, data);
    }

    protected override void AwakeImpl()
    {
        base.AwakeImpl();

        _maxCount = 4;
        for (int i = 0; i < _maxCount; i++)
        {
            var obj = Instantiate(Obj, CharacterPivot);
            obj.GetComponent<SelectCharacterPopup_Character>().SetCharacter(i);
        }
    }

    void OnClickLeftButton()
    {
        if (_currentInx <= 0) return;

        _currentInx--;
        SetIdx(true);
    }

    void OnClickRightButton()
    {
        if (_currentInx >= _maxCount - 1) return;

        _currentInx++;
        SetIdx(false);
    }

    void SetIdx(bool isLeft)
    {
        CharacterPivot.DOKill();
        CharacterPivot.DOLocalMoveX(((960f * _currentInx) * -1.0f) - 850f, 0.5f).SetEase(Ease.OutQuint);
    }

    void OnClickStart()
    {
        var table = Table_Manager.Instance.GetTable<Table_Characters>(_currentInx);
        SendMessage(MessageID.Call_Scene_Load, Type_SceneName.BattleScene);
        SendMessage(MessageID.Call_Scene_MesssageAfterLoad, new Msg_DeliveryData(MessageID.Event_Battle_Info, new Msg_BattleInfo { StoryName = table.story }));
    }
}
