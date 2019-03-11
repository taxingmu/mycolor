using UnityEngine;

public class ColorIndicator : MonoBehaviour {

	HSBColor color;

	void Start() {
		color = HSBColor.FromColor(GetComponent<Renderer>().sharedMaterial.GetColor("_Color"));
		transform.parent.BroadcastMessage("SetColor", color);
	}

	void ApplyColor ()
	{
		GetComponent<Renderer>().sharedMaterial.SetColor ("_Color", color.ToColor());
		transform.parent.BroadcastMessage("OnColorChange", color, SendMessageOptions.DontRequireReceiver);
	}
    //https://blog.csdn.net/swj524152416/article/details/52931521
    //hue色相，saturation饱和度，brightness明度，
    void SetHue(float hue)
	{
        Debug.Log(hue);
		color.h = hue;
		ApplyColor();
    }	

	void SetSaturationBrightness(Vector2 sb) {
		color.s = sb.x;
		color.b = sb.y;
        Debug.Log("bbbb" + color.b);
		ApplyColor();
	}
}
