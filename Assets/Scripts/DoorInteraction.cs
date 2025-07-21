using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public Transform pivot;         // assign the door pivot in inspector
    public float openAngle = 90f;   // angle to open
    public float openSpeed = 2f;    // speed of opening
    public bool isOpen = false;

    private bool playerInRange = false;
    private Quaternion closedRotation;
    private Quaternion openedRotation;

    void Start()
    {
        closedRotation = pivot.localRotation;
        openedRotation = closedRotation * Quaternion.Euler(0, openAngle, 0);
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
        }

        if (isOpen)
        {
            pivot.localRotation = Quaternion.Lerp(pivot.localRotation, openedRotation, Time.deltaTime * openSpeed);
        }
        else
        {
            pivot.localRotation = Quaternion.Lerp(pivot.localRotation, closedRotation, Time.deltaTime * openSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}
