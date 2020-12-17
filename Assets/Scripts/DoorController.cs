using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public GameObject character;
    public float distance = 3f;
    private Animator animator;

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
            animator.SetBool("character_nearby", true);
        }
    }
}
