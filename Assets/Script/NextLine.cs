
using UnityEngine;

public class NextLine : MonoBehaviour
{
    public GameObject spike;
    public float Minspeed;
    public float Maxspeed;
    public float currentspeed;
    private void Awake()
    {
        currentspeed = Minspeed;
        generatespike();
    }
    void generatespike()
    {
        GameObject spikeIns = Instantiate(spike, transform.position, transform.rotation);
    }




    void Update()
    {
        
    }
}
