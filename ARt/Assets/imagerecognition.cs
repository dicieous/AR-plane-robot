using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class imagerecognition : MonoBehaviour
{
    private ARTrackedImageManager _artrackedimage;
    private void Awake()
    {
        _artrackedimage = FindObjectOfType<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        _artrackedimage.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable()
    {
        _artrackedimage.trackedImagesChanged -= OnImageChanged;
    }

    private void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var trackedimage in args.added)
        {
            Debug.Log(trackedimage.name);
        }
    }
}
