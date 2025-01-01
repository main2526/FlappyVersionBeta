using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed *  Time.deltaTime;
    }
}
