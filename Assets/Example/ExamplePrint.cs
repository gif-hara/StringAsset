using UnityEngine;
using UnityEngine.Assertions;
using System.Collections.Generic;

public class ExamplePrint : MonoBehaviour
{
	[SerializeField]
	private StringAsset.Finder finder;

	void Start()
	{
		Debug.Log(this.finder.Get);
	}
}
