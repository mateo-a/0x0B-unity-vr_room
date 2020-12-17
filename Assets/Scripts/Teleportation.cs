using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform player;
    public Animator fade;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    public void MovePlayer()
    {
        Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform != null)
            {
                fade.SetTrigger("Blink1");
                player.position = hit.point;
                fade.SetTrigger("Blink2");
            }
        }
    }
}
