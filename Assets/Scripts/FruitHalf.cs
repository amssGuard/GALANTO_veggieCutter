using UnityEngine;

public class FruitHalf : MonoBehaviour
{
    private bool isSelected = false;
    public float moveSpeed = 3f;

    // Optional highlight when selected
    public Color highlightColor = Color.yellow;
    private Color originalColor;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend != null)
            originalColor = rend.material.color;
    }

    void OnMouseDown()
    {
        // Toggle selection on click
        isSelected = !isSelected;

        if (rend != null)
            rend.material.color = isSelected ? highlightColor : originalColor;
    }

    void Update()
    {
        if (!isSelected) return;

        float horizontal = 0f;
        if (Input.GetKey(KeyCode.LeftArrow)) horizontal = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) horizontal = 1f;

        Vector3 move = new Vector3(horizontal * moveSpeed * Time.deltaTime, 0f, 0f);
        transform.Translate(move, Space.World);
    }

    public bool IsSelected()
    {
        return isSelected;
    }

    public void SetSelected(bool selected)
    {
        isSelected = selected;
        if (rend != null)
            rend.material.color = selected ? highlightColor : originalColor;
    }
}
