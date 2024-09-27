using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spirit : MonoBehaviour
{
    public void Interact(Transform player)
    {
        Debug.Log("Spirit: Hello!");
    }

    public Transform GetTransform()
    {
        return transform;
    }

    public string GetInteractText()
    {
        return "Talk to Spirit";
    }

    public void ReceiveItem(string item)
    {
        Debug.Log($"Spirit received: {item}");
        // You can add custom logic here, like a response or a reward
    }
}
