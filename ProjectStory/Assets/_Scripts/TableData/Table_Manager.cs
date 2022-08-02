using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table_Manager
{
    public static Table_Manager Instance = new Table_Manager();

    bool _init = false;

    Dictionary<System.Type, List<Table_Base>> _staticDataList = new Dictionary<System.Type, List<Table_Base>>();
    Dictionary<System.Type, string> _typeList = new Dictionary<System.Type, string>();

    public Table_Manager()
    {
        //_typeList.Add(typeof(Table_Character), "Character");
        _typeList.Add(typeof(Table_Characters), "Characters");
        _typeList.Add(typeof(Table_Story_blaster), "Story_Blaster");
        _typeList.Add(typeof(Table_Story_sorceress), "Story_Sorceress");
        Init();
    }

    public void Init(bool force = false)
    {
        if (true == force)
        {
            _staticDataList.Clear();

            _init = false;
        }

        if (false == _init)
        {
            _init = true;            

            Load(false);
        }
    }

    public void Init_AssetBundle()
    {
        _staticDataList.Clear();
        Load(true);
    }

    void Load(bool assetbundle)
    {
        foreach (var typeInfo in _typeList)
        {
            var tableData = "";

            if (true == assetbundle)
            {
                tableData = ResourceLoad.GetTableData(typeInfo.Value);
            }
            else
            {
                var asset = Resources.Load<TextAsset>("Data/TableData/" + typeInfo.Value);
                if (null != asset)
                {
                    tableData = asset.text;
                }
            }

            if (string.IsNullOrEmpty(tableData))
            {
                continue;
            }
            
            var text = Encrypt.AESDecrypt256(tableData);
            List<Table_Base> dataList = null;

            Table_Base baseData = null;
            if (false == string.IsNullOrEmpty(text))
            {
                dataList = new List<Table_Base>();

                text = text.Replace("\r", "");
                var lines = text.Split('\n');

                object[] formParameters = new object[1];
                for (int i = 0; i < lines.Length; i++)
                {
                    formParameters[0] = lines[i].Split(',');

                    try
                    {
                        baseData = (Table_Base)System.Activator.CreateInstance(typeInfo.Key, formParameters);
                    }
                    catch (System.Exception e)
                    {
                        LogManager.LogError(typeInfo.Key + "[" + i + "] /" + lines[i] + " /" + e);
                        break;
                    }
                    
                    dataList.Add(baseData);
                }

                _staticDataList.Add(typeInfo.Key, dataList);
            }
        }
    }

    public T GetTable<T>(int id)
    {
        Table_Base data = null;

        List<Table_Base> list = null;

        _staticDataList.TryGetValue(typeof(T), out list);

        if (null != list)
        {
            data = list.Find((listData) => listData.DataID.Equals(id));
        }
        else
        {
            LogManager.LogError("GetData:" + typeof(T) + " ID:" + id);
        }

        return (T)System.Convert.ChangeType(data, typeof(T));
    }

    public List<T> GetTables<T>()
    {
        List<T> dataList = new List<T>();

        List<Table_Base> list = null;
        _staticDataList.TryGetValue(typeof(T), out list);

        if (null != list)
        {
            foreach (var data in list)
            {
                dataList.Add((T)System.Convert.ChangeType(data, typeof(T)));
            }
        }
        else
        {
            LogManager.LogError("GetDataList:" + typeof(T));
        }

        return dataList;
    }

}

