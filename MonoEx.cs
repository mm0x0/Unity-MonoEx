using UnityEngine;
using System;

public class MonoEx
{
	// シーン上のコンポーネントの取得（なければ作成）
	public static T CreateGetComponent <T> ()
		where T : Component
	{
		T component;

		if (GameObject.FindObjectsOfType <T> ().Length == 0)
			component = new GameObject (typeof (T).Name).AddComponent <T> ();
		else
			component = (T) GameObject.FindObjectsOfType <T> () [0];

		return (T) component;
	}

	// シーン上に2つ以上同じコンポーネントがあるか判別
	public static bool DoubleComponentsInScene<T> ()
		where T : Component
		=> GameObject.FindObjectsOfType <T> ().Length >= 2;
}