
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    public spikegenerator spikegenerator;

    void Update()
    {
        transform.Translate(Vector2.left * 5 * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NextLine"))
        {
           spikegenerator.GenerateNextSpikeWithGap();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }

    }
     
}
