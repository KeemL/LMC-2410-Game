using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerScript playerInteract;

    [SerializeField] private TextMeshProUGUI interactTextMeshProUGUI;



    private void Update()
    {
        if (playerInteract.GetInteractableObject() != null)
        {
            Show(playerInteract.GetInteractableObject());
        }
        else
        {
            Hide();
        }
    }


    private void Show(IInteractable interactable)
    {
        containerGameObject.SetActive(true);
        if (interactable != null)
        {
            interactTextMeshProUGUI.text = interactable.GetInteractText();
        }
    }

    // Add a method to display dialogue
    public void ShowDialogue(string message)
    {
        // Create a dialogue UI element, or use an existing one
        interactTextMeshProUGUI.text = message; // or use a separate TextMeshPro for dialogue
    }

    private void Hide()
    {
        containerGameObject.SetActive(false);
    }
}
