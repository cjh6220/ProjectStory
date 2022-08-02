using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterPopup_Character : MessageListener
{
    public Image Character;
    public Transform Def, Atk, Spd;

    public void SetCharacter(int idx)
    {
        var table = Table_Manager.Instance.GetTable<Table_Characters>(idx);
        Character.sprite = ResourceLoad.GetCharacterIllust(table.resource);

        for (int i = 0; i < Def.childCount; i++)
        {
            var bar = Def.GetChild(i).GetComponent<Image>();
            Color color;
            if (i < table.def)
            {
                ColorUtility.TryParseHtmlString("#0E8E51", out color);
            }
            else
            {
                ColorUtility.TryParseHtmlString("#FFFFFF", out color);
            }
            bar.color = color;
        }

        for (int i = 0; i < Atk.childCount; i++)
        {
            var bar = Atk.GetChild(i).GetComponent<Image>();
            Color color;
            if (i < table.atk)
            {
                ColorUtility.TryParseHtmlString("#EF1111", out color);
            }
            else
            {
                ColorUtility.TryParseHtmlString("#FFFFFF", out color);
            }
            bar.color = color;
        }

        for (int i = 0; i < Spd.childCount; i++)
        {
            var bar = Spd.GetChild(i).GetComponent<Image>();
            Color color;
            if (i < table.speed)
            {
                ColorUtility.TryParseHtmlString("#1265F1", out color);
            }
            else
            {
                ColorUtility.TryParseHtmlString("#FFFFFF", out color);
            }
            bar.color = color;
        }
    }
}
