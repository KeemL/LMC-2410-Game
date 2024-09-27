using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IInteractable
{
    public float InteractionRange => 1.5f;

    private bool isPlayerInRange = false;

    private bool hasItem = false;

    //public valueSaver script;

    void Start()
    {

        gameObject.SetActive(true);
        Debug.Log("Actively");


    }

    private void Update()
    {
        if (isPlayerInRange && Input.GetButton("EKey"))
        {
            Debug.Log("pressed E frl");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("in range");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    private void CollectItem()
    {
        // Perform Item collection logic here
        gameObject.SetActive(false); // Disable the Item GameObject
        hasItem = true;
        Debug.Log("collected Item");
    }

    public void Interact(Transform interactorTransform)
    {
        // if (interactorTransform.)
        CollectItem();
    }

    public string GetInteractText()
    {
        return "Collect Item";
    }

    public Transform GetTransform()
    {
        return transform;
    }


}