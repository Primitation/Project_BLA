using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invetorymanager : MonoBehaviour
{
    public static Invetorymanager Instance;

    public List<Allitems> _inventoryItems = new List<Allitems>(); // Our inventory items
    private void Awake()
    {
        Instance = this;
    }

    public void AddItem (Allitems item)
    {
        if (!_inventoryItems.Contains(item))
        {
            _inventoryItems.Add(item);
        }
    }
    public void RemoveItem (Allitems item)
    {
        if (_inventoryItems.Contains(item))
        {
            _inventoryItems.Remove(item);
        }
    }
    public enum Allitems
    {
        KeyRed,
        KeyBlue,
        KeyGreen
    }   
}
