using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Color[] colors = {Color.brown,Color.darkBlue,Color.white,Color.limeGreen};
    private Renderer _renderer;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls"))
        {
            ColorChange();
        }
    }
    void ColorChange()
    {
        var randomColor = colors[Random.Range(0,colors.Length)];
        _renderer.material.color = randomColor; 
    }
}
