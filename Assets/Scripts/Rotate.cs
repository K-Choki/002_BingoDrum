using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float RotSpeed = 10;
    Transform transform;
    void Start()
    {
        transform = GetComponent<Transform>();
    }
    void Update()
    {
        transform.Rotate(Vector3.forward * RotSpeed * Time.deltaTime);
    }
}
