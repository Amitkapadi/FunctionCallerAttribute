using UnityEngine;
using UnityEditor;
using System.Collections;


[CustomEditor( typeof( SomeType ) )]
public class SomeTypeEditor : AbstractFunctionCallerEditor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
	}
}
