using UnityEngine;

public class BallsizeChanger : MonoBehaviour
{
    [SerializeField] private float minSize = 0.9f;
    [SerializeField] private float maxSize = 1.5f;
    [SerializeField] 
    private Vector3 originalScale;
    void Start()
    {
        originalScale = transform.localScale;
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            float randomScale = Random.Range(minSize, maxSize);
            transform.localScale = Vector3.one * randomScale;
        }
    }
    
}
