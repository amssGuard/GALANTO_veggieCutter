using UnityEngine;

public class FruitPicker : MonoBehaviour
{
    private FruitHalf selectedHalf;
    public float rayDistance = 10f;
    public Camera cam;

    void Start()
    {
        if (cam == null)
            cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                 Debug.Log("Hit: " + hit.collider.name);
                FruitHalf half = hit.collider.GetComponent<FruitHalf>();

                if (half != null)
                {
                    if (selectedHalf != null)
                        selectedHalf.SetSelected(false);

                    selectedHalf = half;
                    selectedHalf.SetSelected(true);
                }
            }
        }
    }
}
