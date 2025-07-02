using UnityEngine;

public class Instantiation : MonoBehaviour
{
    InputSystem_Actions action;
    [SerializeField] private GameObject[] gameObjects;
    Vector3 startPosition;
    [SerializeField] private float forceImpulse = 5f;
    
    private void Awake()
    {
        action = new InputSystem_Actions();
    }
    void Start()
    {
        startPosition = new Vector3 (0,1,0);  
    }

    
    void Update()
    {
        var inputInterract = action.Player.Interact.triggered;

        if (inputInterract)
        {
            SpawnPrefabs();
        }
    }
    private void SpawnPrefabs()
    {
        int randomIndex = Random.Range(0, gameObjects.Length);
        var spawnObject = Instantiate(gameObjects[randomIndex], startPosition, Quaternion.identity);
        Vector3 randomDirection = new Vector3(Random.Range(-1, 1),0, Random.Range(-1, 1));
        Rigidbody body = spawnObject.GetComponent<Rigidbody>();
        body.AddForce(randomDirection * forceImpulse, ForceMode.Impulse);

    }
    private void OnEnable()
    {
        action.Enable();
    }
    private void OnDisable()
    {
        action.Disable();   
    }
}
