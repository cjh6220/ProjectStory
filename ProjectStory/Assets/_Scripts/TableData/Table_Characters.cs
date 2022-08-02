using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class Table_Characters : Table_Base
{
    public Table_Characters(string[] data)
    {
        if (false == string.IsNullOrEmpty(data[0]))
            id = System.Convert.ToInt32(data[0]);
        if (false == string.IsNullOrEmpty(data[0]))
            DataID = System.Convert.ToInt32(data[0]);
        annotation = data[1];
        if (false == string.IsNullOrEmpty(data[2]))
            type_link = System.Convert.ToInt32(data[2]);
        resource = data[3];
        name = data[4];
        if (false == string.IsNullOrEmpty(data[5]))
            def = System.Convert.ToInt32(data[5]);
        if (false == string.IsNullOrEmpty(data[6]))
            atk = System.Convert.ToInt32(data[6]);
        if (false == string.IsNullOrEmpty(data[7]))
            speed = System.Convert.ToInt32(data[7]);
        story = data[8];
    }

    public ObscuredInt id;
    public ObscuredString annotation;
    public ObscuredInt type_link;
    public ObscuredString resource;
    public ObscuredString name;
    public ObscuredInt def;
    public ObscuredInt atk;
    public ObscuredInt speed;
    public ObscuredString story;
}