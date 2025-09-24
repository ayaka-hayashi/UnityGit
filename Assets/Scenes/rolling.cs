using UnityEngine;

public class rolling : MonoBehaviour
{
    public float rollX;
    public float rollY;
    public float rollZ;
    public float posX;
    public float posY;
    public float posZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rollX, rollY, rollZ);
        //transform.position(posX, posY, posZ);
         transform.Translate(Vector3.right * 0.1f * Time.deltaTime);
    }
}
