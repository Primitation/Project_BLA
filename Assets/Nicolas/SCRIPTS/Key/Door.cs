using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    Invetorymanager.Allitems _Requireditem;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (HasRequiredItem(_Requireditem))
            {
                Destroy(gameObject);
            }
        }
    }

    public bool HasRequiredItem (Invetorymanager.Allitems itemrequired)
    {
        if (Invetorymanager.Instance._inventoryItems.Contains(itemrequired))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
