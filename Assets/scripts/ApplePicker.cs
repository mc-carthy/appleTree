using UnityEngine;
using System.Collections.Generic;

[AddComponentMenu ("Vistage/ApplePicker")]
public class ApplePicker : MonoBehaviour {

	public GameObject basketPrefab;
	public int numBaskets;
	public float basketBottomY;
	public float basketSpacingY;

	private List<GameObject> baskets = new List<GameObject> ();

	private void Start ()
	{
		for (int i = 0; i < numBaskets; i++)
		{
			GameObject basketGO = Instantiate (basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottomY + (basketSpacingY * i);
			basketGO.transform.position = pos;
			baskets.Add (basketGO);
		}
	}

	public void AppleDestroyed ()
	{
		GameObject[] apples = GameObject.FindGameObjectsWithTag("apple");

		foreach (GameObject go in apples)
		{
			Destroy (go);
		}

		int topBasketIndex = baskets.Count - 1;
		GameObject topBasketGO = baskets[topBasketIndex];

		baskets.RemoveAt (topBasketIndex);
		Destroy (topBasketGO);
	}
}
