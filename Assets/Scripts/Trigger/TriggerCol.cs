using UnityEngine;

public class TriggerCol : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Triggered with: {other.gameObject}");
    }
}
