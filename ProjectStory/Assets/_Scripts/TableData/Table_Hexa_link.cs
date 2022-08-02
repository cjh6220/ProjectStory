using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class Table_Hexa_link : Table_Base
{
    public Table_Hexa_link(string[] data)
    {
        if (false == string.IsNullOrEmpty(data[0]))
            id = System.Convert.ToInt32(data[0]);
        if (false == string.IsNullOrEmpty(data[0]))
            DataID = System.Convert.ToInt32(data[0]);
        annotation = data[1];
        if (false == string.IsNullOrEmpty(data[2]))
            type_list = System.Convert.ToInt32(data[2]);
        if (false == string.IsNullOrEmpty(data[3]))
            grade = System.Convert.ToInt32(data[3]);
        if (false == string.IsNullOrEmpty(data[4]))
            type_link = System.Convert.ToInt32(data[4]);
        resource = data[5];
        unit_name = data[6];
        unit_skill = data[7];
        unit_skill_expl = data[8];
        unit_skill_expl_add = data[9];
    }

    public ObscuredInt id;
    public ObscuredString annotation;
    public ObscuredInt type_list;
    public ObscuredInt grade;
    public ObscuredInt type_link;
    public ObscuredString resource;
    public ObscuredString unit_name;
    public ObscuredString unit_skill;
    public ObscuredString unit_skill_expl;
    public ObscuredString unit_skill_expl_add;
}