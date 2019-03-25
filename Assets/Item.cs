using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item { 
    public GameObject itemGo;

    private Text nameTxt;
    private Text ageTxt;

    public Item(GameObject go) { 
        this.itemGo = go;

        if (itemGo) {
            nameTxt = itemGo.transform.Find("NameTxt").GetComponent<Text>();
            ageTxt = itemGo.transform.Find("AgeTxt").GetComponent<Text>();
        }
    }

    public void SetData(ItemData data) {
        if (data != null) {
            nameTxt.text = data.m_Name;
            ageTxt.text = data.m_Age.ToString();
        }  
    }
}

public class ItemData {
    private string Name = string.Empty;
    public string m_Name {
        get {
            return this.Name;
        }
    }
    private int Age = 0;
    public int m_Age {
        get {
            return this.Age;
        }
    }

    public ItemData(string name, int age) {
        this.Name = name;
        this.Age = age;
    }
}
