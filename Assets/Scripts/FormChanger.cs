using UnityEngine;

public class FormChanger : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    private Rigidbody rb;
    private Transform ourSphere;
    private Vector3 savedVelocity;
    private Vector3 savedAngularVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        ourSphere = GetComponent<Transform>();
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            ChangeForm();
        }
    }
    private void ChangeForm()
    {
        Vector3 pos = ourSphere.position;
        Quaternion rot = ourSphere.rotation;
        savedVelocity = rb.linearVelocity;
        savedAngularVelocity = rb.angularVelocity;
        GameObject newPrefab = objects[Random.Range(0, objects.Length)];
        GameObject newInst = Instantiate(newPrefab,pos,rot);

        Rigidbody newRB = newInst.GetComponent<Rigidbody>();   
        newRB.linearVelocity = savedVelocity;
        newRB.angularVelocity = savedAngularVelocity;

        Destroy(gameObject);
        
    }
}
