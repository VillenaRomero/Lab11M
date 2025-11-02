using UnityEngine;

public class movedobstacle : MonoBehaviour
{
    public int speedx;
    private Rigidbody rigibody;
    private Transform comTransform;
    public float speed = 4;

    void Start()
    {
        rigibody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rigibody.linearVelocity = new Vector3(speed * speedx, 0,0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "vacio") {
            Destroy(gameObject);
        }
    }
}
