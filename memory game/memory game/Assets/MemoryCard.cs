using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject card_back;
    [SerializeField] Sprite image;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = image;
    }


    public void OnMouseDown()
    {
        if (card_back.activeSelf) {
            card_back.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
