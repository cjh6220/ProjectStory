using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class Table_Story_sorceress : Table_Base
{
    public Table_Story_sorceress(string[] data)
    {
        if (false == string.IsNullOrEmpty(data[0]))
            id = System.Convert.ToInt32(data[0]);
        if (false == string.IsNullOrEmpty(data[0]))
            DataID = System.Convert.ToInt32(data[0]);
        annotation = data[1];
        bg = data[2];
        image = data[3];
        if (false == string.IsNullOrEmpty(data[4]))
            position = System.Convert.ToInt32(data[4]);
        announce = data[5];
    }

    public ObscuredInt id;
    public ObscuredString annotation;
    public ObscuredString bg;
    public ObscuredString image;
    public ObscuredInt position;
    public ObscuredString announce;
}