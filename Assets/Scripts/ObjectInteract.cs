using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    public Transform character;
    public Transform hand;
    private Camera main;
    public float distance = 3f;

    public void Interact()
    {
        if (Vector3.Distance(character.position, transform.position) <= distance)
        {
            if (hand.childCount == 0)
            {
                Pickup();
            }
            else
            {
                Swap();
            }
        }
        else
        {
            Debug.Log("Out of Range");
        }
    }

    void Pickup()
    {
        // Kinematic
        GetComponent<Rigidbody>().isKinematic = true;
        transform.position = hand.position;
        transform.parent = GameObject.Find("Hand").transform;
    }

    void Swap()
    {
        Transform dropping = hand.GetChild(0);
        dropping.position = transform.position;
        dropping.parent = null;
        Pickup();
        dropping.GetComponent<Rigidbody>().isKinematic = false;
    }
}
