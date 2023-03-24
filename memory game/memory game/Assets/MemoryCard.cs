using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject card_back;
    [SerializeField] SceneController controller;

public void OnMouseDown()
    {
        if (card_back.activeSelf) {
            card_back.SetActive(false);
        }
    }
    private int _id;
    public int Id
    {
        get { return _id; }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }


   

    // Update is called once per frame
    void Update()
    {
        
    }
}
