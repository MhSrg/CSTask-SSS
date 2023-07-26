using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Itemz[] itemsInInventory;

    [System.Serializable]
    public class Itemz
    {
        public string itemName;
        public SO_Items item;
    }
}
