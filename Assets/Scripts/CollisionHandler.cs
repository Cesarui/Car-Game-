using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float delayAmount = 2;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Invoke("ReloadLevel", delayAmount);
            GetComponent<CarMovement>().enabled = false;
            rb.AddExplosionForce(10000, Vector3.down, 1000);
        }
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
