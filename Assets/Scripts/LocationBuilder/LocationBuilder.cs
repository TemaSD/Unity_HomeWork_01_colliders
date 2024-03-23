using Unity.VisualScripting;
using UnityEngine;

public class LocationBuilder : MonoBehaviour
{
    private void Start()
    {
        GameObject Ground = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Ground.name = "Ground";
        Ground.transform.localScale = new Vector3(24.0f, 0.04f, 46.6f);
        Ground.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/ground_mat");
        
        GameObject Player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Player.name = "Player";
        Player.transform.position = new Vector3(0, 1.0f, 0);
        Player.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/player_mat");
        Player.AddComponent<Rigidbody>();
        Player.GetComponent<Rigidbody>().useGravity = false;
        Player.GetComponent<BoxCollider>().isTrigger = true;
        Player.AddComponent<PlayerMovement>();
        
        GameObject Enemy = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Enemy.name = "Enemy";
        Enemy.transform.position = new Vector3(0, 5.0f, 0);
        Enemy.GetComponent<MeshRenderer>().material = Resources.Load<Material>("Materials/enemy_mat");
        Enemy.AddComponent<Rigidbody>();
        Enemy.GetComponent<Rigidbody>().drag = 5;
        Enemy.AddComponent<EnemyCollider>();
        
    }
}
