using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class valueSaver : MonoBehaviour
{
    public static bool hasKey = false;
    public TextMeshProUGUI tmpText;



    [SerializeField] private GameObject containerGameObject;
    // Start is called before the first frame update
    void Start()
    {
        containerGameObject.SetActive(false);
        tmpText.text = "go away scrub";
    }

    // Update is called once per frame
    void Update()
    {
        if (hasKey && Spirit.gotKey)
        {
            tmpText.text = "Thanks scrub";
            containerGameObject.SetActive(true);
        }
    }
}
