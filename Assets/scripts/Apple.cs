using UnityEngine;

[AddComponentMenu ("Vistage/Apple")]
public class Apple : MonoBehaviour {

	private static float bottomY = -20f;

	private void Update ()
	{
		if (transform.position.y < bottomY)
		{
			ApplePicker picker = Camera.main.GetComponent<ApplePicker> ();
			picker.AppleDestroyed ();
			Destroy (gameObject);
		}
	}
}
