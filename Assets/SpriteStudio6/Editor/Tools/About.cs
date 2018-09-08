/**
	SpriteStudio6 Player for Unity

	Copyright(C) Web Technology Corp. 
	All rights reserved.
*/
using UnityEngine;
using UnityEditor;

public sealed class MenuItem_SpriteStudio6_About : EditorWindow
{
	/* ----------------------------------------------- Functions */
	#region Functions
	[MenuItem("Tools/SpriteStudio6/About")]
	static void About()
	{
		EditorUtility.DisplayDialog(	Library_SpriteStudio6.SignatureNameAsset,
										Library_SpriteStudio6.SignatureNameAsset
										+ "\n\n"
										+ "Version: " + Library_SpriteStudio6.SignatureVersionAsset
										+ "\n\n"
										+ "Copyright(C) " + Library_SpriteStudio6.SignatureNameDistributor,
										"OK"
									);
	}
	#endregion Functions
}
