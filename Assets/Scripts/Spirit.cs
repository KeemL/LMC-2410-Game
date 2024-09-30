using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit : MonoBehaviour, IInteractable
{
    public float InteractionRange => 1.5f; // Adjust as needed

    private bool isPlayerInRange = false;

    // Reference to the key item type (could be an Item script)
    public Item requiredItem; // Assign this in the inspector

    void Update()
    {
        if (isPlayerInRange && Input.GetButton("EKey"))
        {
            PlayerScript player = FindObjectOfType<PlayerScript>(); // Find the player script instance
            Interact(player.transform);
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

    public void Interact(Transform interactorTransform)
    {
        PlayerInventory playerInventory = interactorTransform.GetComponent<PlayerScript>().playerInventory;

        if (playerInventory.HasItem(requiredItem))
        {
            Debug.Log("Thank you!"); // Replace this with UI dialogue display logic
            playerInventory.RemoveItem(requiredItem); // Optionally remove the item from the inventory
        }
        else
        {
            Debug.Log("Please bring me the key."); // Replace this with UI dialogue display logic
        }
    }

    public string GetInteractText()
    {
        return "Talk to Spirit";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
