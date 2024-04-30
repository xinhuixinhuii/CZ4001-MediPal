using UnityEngine;
using UnityEngine.UI;

public class ToggleObjectVisibility : MonoBehaviour
{
    public GameObject objectToToggle;

    private bool isVisible = false;

    public void ToggleVisibility()
    {
        isVisible = !isVisible;
        objectToToggle.SetActive(isVisible);
    }
}
