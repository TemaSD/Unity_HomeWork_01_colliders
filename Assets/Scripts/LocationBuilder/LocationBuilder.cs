using UnityEngine;

public class LocationBuilder : MonoBehaviour
{
    private void Start()
    {
        GameObject Ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Ground.transform.localScale = new Vector3(24.0f, 0.04f, 46.6f);
        
        GameObject Player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Player.transform.position = new Vector3(0, 0.5f, 0);
        Player.AddComponent<Rigidbody>();
        Player.GetComponent<Rigidbody>().drag = 5;
        Player.AddComponent<PlayerMovement>();
        //Player.GetComponent<PlayerMovement>().moveSpeed = 0.01;
        
        
        GameObject Enemy = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Enemy.transform.position = new Vector3(0, 5.0f, 0);
        Enemy.AddComponent<Rigidbody>();
        Enemy.GetComponent<Rigidbody>().drag = 5;
        Enemy.AddComponent<EnemyCollider>();
        
    }
}
