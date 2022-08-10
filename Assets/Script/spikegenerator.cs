
using UnityEngine;

public class spikegenerator : MonoBehaviour
{
    
    public GameObject spike;
    public float Minspeed;
    public float Maxspeed;
    public float currentspeed;
    public float SpeedMultiplier;
    private void Awake()
    {
        currentspeed = Minspeed;
        generatespike();
    }
      public void GenerateNextSpikeWithGap()
    {
        float randomwait = Random.Range(0.1f, 1.2f);
        Invoke("generatespike", randomwait);
    }
    void generatespike()
    {
        GameObject spikeIns = Instantiate(spike, transform.position, transform.rotation);
        spikeIns.GetComponent<SpikeScript>().spikegenerator = this;
    }




    void Update()
    {
        if (currentspeed < Maxspeed)
        {
            currentspeed += SpeedMultiplier;
        }
        
    }
}
