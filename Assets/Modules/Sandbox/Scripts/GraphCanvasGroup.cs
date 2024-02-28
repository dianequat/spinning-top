// ----------------------------------------------------------------------------------------------------------
// Author: Austin Peel
//
// © All rights reserved. ECOLE POLYTECHNIQUE FEDERALE DE LAUSANNE, Switzerland, Section de Physique, 2024.
// See the LICENSE.md file for more details.
// ----------------------------------------------------------------------------------------------------------
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class GraphCanvasGroup : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    private void OnEnable()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void SetVisibility(bool isVisible)
    {
        if (!canvasGroup) canvasGroup = GetComponent<CanvasGroup>();

        canvasGroup.alpha = isVisible ? 1 : 0;
        canvasGroup.blocksRaycasts = isVisible;
        canvasGroup.interactable = isVisible;
    }
}
