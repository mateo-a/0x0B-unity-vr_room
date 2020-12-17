using UnityEngine;

public class ProjectorController : MonoBehaviour
{
    public GameObject particles;
    public Transform character;
    public float distance = 3f;

    public void Interact()
    {
        if (Vector3.Distance(character.position, transform.position) <= distance)
        {
            if (particles.activeInHierarchy == false)
            {
                particles.SetActive(true);
            }
            else
            {
                particles.SetActive(false);
            }
        }
    }
}
