using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //inventory array
    private string[] inventoryArray = new[] {"Sword","Shield","Potion"};
    
    //move elements in the array to list
    private List<string> inventoryList;
    
     void Start()
     {
         inventoryList = new List<string>(inventoryArray);
         DisplayInventoryList();
     }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            inventoryList.Add("Helmet");
            DisplayInventoryList();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            inventoryList.Remove("Sword");
            DisplayInventoryList();
        }
    }

    void DisplayInventoryList()
    {
        int i = 0;  
        Debug.Log("Inventory:");
        foreach (var item in inventoryList)
        {
            Debug.Log($"{++i}. {item}");
        }
    }
    
}
