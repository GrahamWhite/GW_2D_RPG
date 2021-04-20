using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{
    public Item item;
    private Image spriteImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        spriteImage = GetComponent<Image>();
        UpdateItem(null);
    }

    public void UpdateItem(Item item)
    {
        this.item = item;

        if(this.item.title != null)
        {
            spriteImage.color = Color.white;
            spriteImage.sprite = this.item.icon;
        }
        else
        {
            spriteImage.color = Color.clear;
        }
    }
}
