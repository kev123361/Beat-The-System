using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MakePurchasableObject {

    [MenuItem("Assets/Create/Purchasable Object")]
    public static void Create()
    {
        PurchasableObject asset = ScriptableObject.CreateInstance<PurchasableObject>();
        AssetDatabase.CreateAsset(asset, "Assets/NewPurchasableObject.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
	
}
