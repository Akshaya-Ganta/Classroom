using UnityEngine;

public class Fans : MonoBehaviour
{
    public GameObject targetObject; // The fan or light object

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            targetObject.SetActive(!targetObject.activeSelf);
        }
    }
}
