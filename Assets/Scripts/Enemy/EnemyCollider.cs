using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Triggered with: {other.gameObject}");
    }
}
