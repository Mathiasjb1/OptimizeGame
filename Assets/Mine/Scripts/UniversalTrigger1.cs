using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalTrigger1 : MonoBehaviour
{
    [SerializeField] private GameObject activateThis;
    private void OnTriggerEnter(Collider other)
    {
        activateThis.SetActive(true);
    }
}
