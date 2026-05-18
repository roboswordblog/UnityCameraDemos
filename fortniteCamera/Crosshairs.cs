using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public int size = 12;
    public int thickness = 2;

    void OnGUI()
    {
        float x = (Screen.width / 2) - (size / 2);
        float y = (Screen.height / 2) - (size / 2);
        GUI.Box(new Rect(x, y + (size / 2) - (thickness / 2), size, thickness), "");
        GUI.Box(new Rect(x + (size / 2) - (thickness / 2), y, thickness, size), "");
    }
}
