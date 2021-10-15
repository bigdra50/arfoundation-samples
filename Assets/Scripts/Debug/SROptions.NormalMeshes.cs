using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public partial class SROptions
{
    private const string CATEGORY_MESHING = "Meshing";
    private const string CATEGORY_GENERAL = "General";

    private ARMeshManager arMeshManager => GameObject.FindObjectOfType<ARMeshManager>();

    [Category(CATEGORY_MESHING)]
    [DisplayName("Normals")]
    [Sort(0)]
    public bool Normals
    {
        get => arMeshManager.normals;
        set => arMeshManager.normals = value;
    }

    [Category(CATEGORY_MESHING)]
    [DisplayName("Tangents")]
    [Sort(1)]
    public bool Tangents
    {
        get => arMeshManager.tangents;
        set => arMeshManager.tangents = value;
    }

    [Category(CATEGORY_MESHING)]
    [DisplayName("TextureCoordinates")]
    [Sort(2)]
    public bool TextureCoordinates
    {
        get => arMeshManager.textureCoordinates;
        set => arMeshManager.textureCoordinates = value;
    }

    [Category(CATEGORY_MESHING)]
    [DisplayName("Colors")]
    [Sort(3)]
    public bool Colors
    {
        get => arMeshManager.colors;
        set => arMeshManager.colors = value;
    }

    [Category(CATEGORY_MESHING)]
    [DisplayName("QueueSize")]
    [Sort(4)]
    public int QueueSize
    {
        get => arMeshManager.concurrentQueueSize;
        set => arMeshManager.concurrentQueueSize = value;
    }
    [Category(CATEGORY_MESHING)]
    [DisplayName("ARMeshManager enabled")]
    [Sort(5)]
    public bool ArMeshManagerEnabled
    {
        get => arMeshManager.enabled;
        set => arMeshManager.enabled = value;
    }

    [Category(CATEGORY_GENERAL)]
    [DisplayName("Reload Scene")]
    [Sort(0)]
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}