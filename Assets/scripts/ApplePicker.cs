using UnityEngine;

[AddComponentMenu ("Vistage/ApplePicker")]
public class ApplePicker : MonoBehaviour {

	public GameObject basketPrefab;
	public int numBaskets;
	public float basketBottomY;
	public float basketSpacingY;

	private void Start ()
	{
		for (int i = 0; i < numBaskets; i++)
		{
			GameObject basketGO = Instantiate (basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottomY + (basketSpacingY * i);
			basketGO.transform.position = pos;
		}
	}
}
