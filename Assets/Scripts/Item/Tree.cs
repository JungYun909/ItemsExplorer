using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Tree : ItemManager
{
    public int treeID;


    public void Start()
    {
        SetTreeID();
    }

    public void SetTreeID()
    {
        ItemManager.random = new System.Random();
        treeID = random.Next(1, 5);

        
    }
}
