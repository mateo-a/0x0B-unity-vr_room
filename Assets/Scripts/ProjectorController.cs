using UnityEngine;

public class ProjectorController : MonoBehaviour
{
    public GameObject particles;
    public Transform character;
    public float distance = 3f;
    public ItemData[] itemData;
    public InventoryItem[] inventoryItems;
    public GameObject text;

    public void Interact()
    {
        if (Vector3.Distance(character.position, transform.position) <= distance)
        {
            if (FindObjectOfType<InventoryControl>().CountItems() < 5)
            {
                Debug.Log("There are missing objects, Interaction");
                text.SetActive(true);
            }
            else if (particles.activeInHierarchy == false)
            {
                particles.SetActive(true);
                text.SetActive(false);
            }
            else
            {
                particles.SetActive(false);
                text.SetActive(false);
            }
        }
    }

    public void ShowMessages()
    {
        if (Vector3.Distance(character.position, transform.position) <= distance)
        {
            if (FindObjectOfType<InventoryControl>().CountItems() < 5)
            {
                Debug.Log("There are missing objects");
                text.SetActive(true);
            }
            else
            {
                Debug.Log("All objects collected");
                text.SetActive(false);
            }
        }
    }
    public void HideMessages()
    {
        text.SetActive(false);
    }
}
