using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class Table_Hexa_object : Table_Base
{
    public Table_Hexa_object(string[] data)
    {
        if (false == string.IsNullOrEmpty(data[0]))
            id = System.Convert.ToInt32(data[0]);
        if (false == string.IsNullOrEmpty(data[0]))
            DataID = System.Convert.ToInt32(data[0]);
        resource = data[1];
        if (false == string.IsNullOrEmpty(data[2]))
            collision = System.Convert.ToInt32(data[2]);
        if (false == string.IsNullOrEmpty(data[3]))
            base_attck_speed = System.Convert.ToInt32(data[3]);
        base_attck_prefab = data[4];
        ob_skill = data[5];
        if (false == string.IsNullOrEmpty(data[6]))
            ob_atk = System.Convert.ToInt32(data[6]);
        if (false == string.IsNullOrEmpty(data[7]))
            ob_speed_atk = System.Convert.ToInt32(data[7]);
        if (false == string.IsNullOrEmpty(data[8]))
            ob_cri_rate = System.Convert.ToInt32(data[8]);
        if (false == string.IsNullOrEmpty(data[9]))
            ob_cri_value = System.Convert.ToInt32(data[9]);
        if (false == string.IsNullOrEmpty(data[10]))
            ob_hp = System.Convert.ToInt32(data[10]);
        if (false == string.IsNullOrEmpty(data[11]))
            ob_speed_move = System.Convert.ToInt32(data[11]);
    }

    public ObscuredInt id;
    public ObscuredString resource;
    public ObscuredInt collision;
    public ObscuredInt base_attck_speed;
    public ObscuredString base_attck_prefab;
    public ObscuredString ob_skill;
    public ObscuredInt ob_atk;
    public ObscuredInt ob_speed_atk;
    public ObscuredInt ob_cri_rate;
    public ObscuredInt ob_cri_value;
    public ObscuredInt ob_hp;
    public ObscuredInt ob_speed_move;
}