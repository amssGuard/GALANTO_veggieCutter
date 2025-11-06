using UnityEngine;

public class FruitCut : MonoBehaviour
{
    public GameObject fullFruit;
    public GameObject leftHalf;
    public GameObject rightHalf;

    public float separationForce = 2f;
    private bool isCut = false;

    void Start()
    {
        leftHalf.SetActive(false);
        rightHalf.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isCut && other.CompareTag("Knife"))
        {
            CutFruit();
        }
    }

    void CutFruit()
    {
        isCut = true;

        fullFruit.SetActive(false);
        leftHalf.SetActive(true);
        rightHalf.SetActive(true);

        Rigidbody rbLeft = leftHalf.GetComponent<Rigidbody>();
        Rigidbody rbRight = rightHalf.GetComponent<Rigidbody>();

        rbLeft.isKinematic = false;
        rbRight.isKinematic = false;

        rbLeft.AddForce(-transform.right * separationForce, ForceMode.Impulse);
        rbRight.AddForce(transform.right * separationForce, ForceMode.Impulse);
    }
}
