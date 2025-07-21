using UnityEngine;

public class OrbitRotation : MonoBehaviour
{
    public Transform centerPoint;   // The point around which blades orbit
    public float orbitSpeed = 50f;  // Speed of orbit

    void Update()
    {
        if (centerPoint != null)
        {
            // Orbit around the center point's Y-axis
            transform.RotateAround(centerPoint.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }
}

