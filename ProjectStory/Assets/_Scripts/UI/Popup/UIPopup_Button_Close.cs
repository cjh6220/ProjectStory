using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPopup_Button_Close : UIBaseButton
{
    protected override void OnClickImpl()
    {
        //SendMessage(MessageID.Call_Audio_PlayFX, String_Audio.backKey_Button);
        SendMessage(MessageID.Call_UI_Pop);
    }
}
