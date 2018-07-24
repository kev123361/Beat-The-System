using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class PurchasableObject : ScriptableObject {

    public string itemName = "Item Name Here";
    public int cost = 5;
    public string description;

    public float healRate = 5f;
}
