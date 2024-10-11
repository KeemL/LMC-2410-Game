using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit02 : MonoBehaviour, IInteractable
{
    public static bool gotBear = false;

    [SerializeField] private GameObject containerGameObject;

    public float InteractionRange => 0.5f;

    public InventorySCRIPT inventory;

    void Start()
    {
        gameObject.SetActive(true);
        containerGameObject.SetActive(false);
    }
    public void ReceiveItem()
    {
        gotBear = true;
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

    public Transform GetTransform()
    {
        return transform;
    }

    public string GetInteractText()
    {
        return "Talk to Spirit 2";
    }
}
