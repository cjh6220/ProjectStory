using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class Table_Hexa_unit : Table_Base
{
    public Table_Hexa_unit(string[] data)
    {
        if (false == string.IsNullOrEmpty(data[0]))
            id = System.Convert.ToInt32(data[0]);
        if (false == string.IsNullOrEmpty(data[0]))
            DataID = System.Convert.ToInt32(data[0]);
        annotation = data[1];
        if (false == string.IsNullOrEmpty(data[2]))
            type_link = System.Convert.ToInt32(data[2]);
        resource = data[3];
    }

    public ObscuredInt id;
    public ObscuredString annotation;
    public ObscuredInt type_link;
    public ObscuredString resource;
}