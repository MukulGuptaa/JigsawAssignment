using System;
using UnityEngine;

namespace UI
{
    /// <summary>
    /// ui data class to store the ui related data. We serialize this class in inspector.
    /// </summary>
    [Serializable]
    public class JigsawPieceUiData
    {
        [SerializeField] public RectTransform initialPos;
        [SerializeField] public RectTransform finalPos;
        [SerializeField] public Sprite sourceImage;
        [NonSerialized] public bool isPlacedSuccessfully;
        [NonSerialized] public int id;
    }
}
