using UnityEngine;

public static class GameObjectEx
{
	// 先祖のコンポーネントを取得
	public static T GetComponentInParents <T> (this GameObject obj)
		where T : Component
	{
		object comp = obj.GetComponent <T> ();

		if (comp == null)
		{
			Transform t = obj.transform.parent;

			while (t != null && comp == null)
			{
				comp = t.gameObject.GetComponent <T> ();
				t = t.parent;
			}
		}

		return (T) comp;
	}
}