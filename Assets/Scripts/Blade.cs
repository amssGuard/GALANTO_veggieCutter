using UnityEngine;

public class Blade : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float minZ = -2f;
    public float maxZ = 2f;
    public float minY = 0.5f;
    public float maxY = 3f;
    public float fixedX = 0f;  

    void Start()
    {
        
    }


    void Update()
    {
        float v = 0f;

        if (Input.GetKey(KeyCode.UpArrow)) { v = 1f; }
        if (Input.GetKey(KeyCode.DownArrow)) { v = -1f; }

        transform.Translate(0, 0, v * moveSpeed * Time.deltaTime);

        
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.x = fixedX;             
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);
        transform.position = pos;
        
    }
}
