using System;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public GameObject character;
    public float distance = 3f;
    private Animator animator;
    public Transform hand;
    public ItemData[] itemData;
    public InventoryItem[] inventoryItems;
    public GameObject text;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(character.transform.position, transform.position) >= distance)
        {
            animator.SetBool("character_nearby", false);
        }
    }
    public void Interact()
    {
        if (Vector3.Distance(character.transform.position, transform.position) <= distance)
        {
            // if (hand.Find("key_gold"))
            // {
            //     animator.SetBool("character_nearby", true);
            // }
            // else
            // {
            //     Debug.Log("Need a key!!!");
            // }

            if (FindObjectOfType<InventoryControl>().CheckItem())
            {
                animator.SetBool("character_nearby", true);
                FindObjectOfType<InventoryControl>().DeleteItems();
                text.SetActive(false);
            }
            else
            {
                Debug.Log("Need a key!!!");
                text.SetActive(true);
            }
        }

    }

    public void ShowMessages()
    {
        if (FindObjectOfType<InventoryControl>().CheckItem())
        {
            Debug.Log("You get the key!");
            text.SetActive(false);
        }
        else
        {
            Debug.Log("Need a key!!!");
            text.SetActive(true);
        }
    }
    public void HideMessages()
    {
        text.SetActive(false);
    }
}
