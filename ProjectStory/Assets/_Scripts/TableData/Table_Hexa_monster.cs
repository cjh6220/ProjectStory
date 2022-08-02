using System.Collections;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

public class Table_Hexa_monster : Table_Base
{
    public Table_Hexa_monster(string[] data)
    {
        if (false == string.IsNullOrEmpty(data[0]))
            id = System.Convert.ToInt32(data[0]);
        if (false == string.IsNullOrEmpty(data[0]))
            DataID = System.Convert.ToInt32(data[0]);
        if (false == string.IsNullOrEmpty(data[1]))
            type_monster = System.Convert.ToInt32(data[1]);
        resource = data[2];
        if (false == string.IsNullOrEmpty(data[3]))
            damage = System.Convert.ToInt32(data[3]);
        monster_skill = data[4];
        if (false == string.IsNullOrEmpty(data[5]))
            hp = System.Convert.ToInt32(data[5]);
        if (false == string.IsNullOrEmpty(data[6]))
            hp_bonus = System.Convert.ToInt32(data[6]);
        if (false == string.IsNullOrEmpty(data[7]))
            speed_move = System.Convert.ToInt32(data[7]);
        if (false == string.IsNullOrEmpty(data[8]))
            speed_move_bonus = System.Convert.ToInt32(data[8]);
        if (false == string.IsNullOrEmpty(data[9]))
            cri_resist = System.Convert.ToInt32(data[9]);
        if (false == string.IsNullOrEmpty(data[10]))
            cri_resist_bonus = System.Convert.ToInt32(data[10]);
    }

    public ObscuredInt id;
    public ObscuredInt type_monster;
    public ObscuredString resource;
    public ObscuredInt damage;
    public ObscuredString monster_skill;
    public ObscuredInt hp;
    public ObscuredInt hp_bonus;
    public ObscuredInt speed_move;
    public ObscuredInt speed_move_bonus;
    public ObscuredInt cri_resist;
    public ObscuredInt cri_resist_bonus;
}