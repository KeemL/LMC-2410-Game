using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IInteractable
{
    public float InteractionRange => 1.5f;

    private bool isPlayerInRange = false;

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

    private void CollectCoin()
    {
        // Perform coin collection logic here
        gameObject.SetActive(false); // Disable the coin GameObject
        Debug.Log("collected coin");
    }

    public void Interact(Transform interactorTransform)
    {
        CollectCoin();
    }

    public string GetInteractText()
    {
        return "Collect Coin";
    }

    public Transform GetTransform()
    {
        return transform;
    }


}