using UnityEngine;

public class SROptionsBehaviour : MonoBehaviour
{
    private NormalMeshesOptions _normalMeshesOptions;
    
    void Awake()
    {
        _normalMeshesOptions = new NormalMeshesOptions();
        SRDebug.Instance?.AddOptionContainer(_normalMeshesOptions);
    }

    private void OnDestroy()
    {
        SRDebug.Instance?.RemoveOptionContainer(_normalMeshesOptions);
    }
}
