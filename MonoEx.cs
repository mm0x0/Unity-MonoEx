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

	// シーン上に１つだけあるコンポーネントを取得
	public static T GetOnlyOneComponent <T> () where T : Component
	{
		T [] components = GameObject.FindObjectsOfType <T> ();

		if (components.Length == 0)
		   Debug.LogError (typeof (T) + " がシーン上にないよ");

		if (components.Length >= 2)
		   Debug.LogError (typeof (T) + " を2つ以上置いちゃだめだよ");

		return components [0];
	}

	// シーン上に2つ以上同じコンポーネントがあるか判別
	public static bool DoubleComponentsInScene<T> ()
		where T : Component
		=> GameObject.FindObjectsOfType <T> ().Length >= 2;
}