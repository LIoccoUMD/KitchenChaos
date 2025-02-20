using System.ComponentModel;
using UnityEngine;

// Never write to ScriptableObject, READ. ONLY.

[CreateAssetMenu()]
public class KitchenObjectSO : ScriptableObject {
    public Transform prefab;
    public Sprite sprite;
    public string objectName;

}
