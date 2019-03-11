using UnityEngine;

public class ExampleColorReceiver : MonoBehaviour {
	
    Color color;

	void OnColorChange(HSBColor color) 
	{
        this.color = color.ToColor();
	}

    void OnGUI()
    {
		var r = Camera.main.pixelRect;
		var rect = new Rect(r.center.x + r.height / 6 + 50, r.center.y, 100, 100);
		GUI.Label (rect, "#" + ToHex(color.r) + ToHex(color.g) + ToHex(color.b));
        //GUI.Label(Rect(100, 10, 100, 30), "kuan" + Screen.width);
    }

	string ToHex(float n)
	{
		return ((int)(n * 255)).ToString("X").PadLeft(2, '0');
	}
}
