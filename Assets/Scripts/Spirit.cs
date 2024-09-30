using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit : MonoBehaviour, IInteractable
{


    public static bool gotKey = false;

    [SerializeField] private GameObject containerGameObject;

    public float InteractionRange => 1.5f;

    void Start()
    {
        gameObject.SetActive(true);
        containerGameObject.SetActive(false);
    }
    public void ReceiveItem()
    {
        gotKey = true;
        //Debug.Log($"Spirit received: {item}");
        // You can add custom logic here, like a response or a reward
    }

    public void speakToSpirit()
    {
        containerGameObject.SetActive(true);
    }

    public void Interact(Transform interactorTransform)
    {
        ReceiveItem();
        speakToSpirit();
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

}
