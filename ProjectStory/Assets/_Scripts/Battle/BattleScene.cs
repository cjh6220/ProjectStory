using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleScene : MessageListener
{
    public Image Bg, Character;
    public TextMeshProUGUI Text;
    public List<Transform> CharacterPos;
    public Button NextButton;
    List<Data_Story> StoryData = new List<Data_Story>();
    int _currentInx = 0;

    protected override void AddMessageListener()
    {
        base.AddMessageListener();

        AddListener(MessageID.Event_Battle_Info);
        NextButton.onClick.AddListener(NextDialogue);
    }

    protected override void OnMessage(MessageID msgID, object sender, object data)
    {
        base.OnMessage(msgID, sender, data);

        switch (msgID)
        {
            case MessageID.Event_Battle_Info:
                {
                    var info = data as Msg_BattleInfo;
                    LoadStory(info);
                    SetDialogue();
                }
                break;
        }
    }

    void LoadStory(Msg_BattleInfo info)
    {
        StoryData.Clear();
        switch (info.StoryName)
        {
            case "story_blaster":
                {
                    var table = Table_Manager.Instance.GetTables<Table_Story_blaster>();
                    for (int i = 0; i < table.Count; i++)
                    {
                        var story = new Data_Story();
                        story.Id = table[i].id;
                        story.Bg = table[i].bg;
                        story.Image = table[i].image;
                        story.Position = table[i].position;
                        story.Announce = table[i].announce;

                        StoryData.Add(story);
                    }
                }
                break;
            case "story_sorceress":
                {
                    var table = Table_Manager.Instance.GetTables<Table_Story_sorceress>();
                    for (int i = 0; i < table.Count; i++)
                    {
                        var story = new Data_Story();
                        story.Id = table[i].id;
                        story.Bg = table[i].bg;
                        story.Image = table[i].image;
                        story.Position = table[i].position;
                        story.Announce = table[i].announce;

                        StoryData.Add(story);
                    }
                }
                break;
        }
    }

    void SetDialogue()
    {
        if (_currentInx >= StoryData.Count)
        {
            SendMessage(MessageID.Call_Scene_Load, Type_SceneName.LobbyScene);
            return;
        }

        var currentDialogue = StoryData[_currentInx];

        if (!string.IsNullOrEmpty(currentDialogue.Bg))
        {
            Bg.sprite = ResourceLoad.GetBg(currentDialogue.Bg);
        }

        if (!string.IsNullOrEmpty(currentDialogue.Image))
        {
            Character.sprite = ResourceLoad.GetCharacterIllust(currentDialogue.Image);
        }

        Character.transform.SetParent(CharacterPos[currentDialogue.Position]);
        Character.transform.localPosition = Vector3.zero;
        Text.SetText(currentDialogue.Announce);
    }

    void NextDialogue()
    {
        _currentInx++;
        SetDialogue();
    }
}
