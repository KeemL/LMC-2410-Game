using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit02 : MonoBehaviour
{
    public static bool gotBear = false;

    [SerializeField] private GameObject containerGameObject;

    public float InteractionRange => 1.5f;

    void Start()
    {
        gameObject.SetActive(true);
        containerGameObject.SetActive(true);
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
