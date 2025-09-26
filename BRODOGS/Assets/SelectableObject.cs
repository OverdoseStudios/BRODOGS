using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SelectableObject : MonoBehaviour
{
    public Color selectedColor = Color.yellow;
    private Color originalColor;
    private static SelectableObject currentSelection;

    void Start()
    {
        // Store original material color
        originalColor = GetComponent<Renderer>().material.color;
    }

    private void OnMouseDown()
    {
        if (currentSelection == this)
        {
            // Deselect if clicking again
            currentSelection = null;
            ApplyColor(originalColor);
        }
        else
        {
            // Deselect previous selection
            if (currentSelection != null)
            {
                currentSelection.ApplyColor(currentSelection.originalColor);
            }

            // Select this object
            currentSelection = this;
            ApplyColor(selectedColor);
        }
    }

    void ApplyColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
}
