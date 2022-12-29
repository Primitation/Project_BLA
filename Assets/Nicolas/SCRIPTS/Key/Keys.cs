using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    [SerializeField]
    Invetorymanager.Allitems _itemType;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Invetorymanager.Instance.AddItem(_itemType);
            Destroy(gameObject);
        }
    }
}
