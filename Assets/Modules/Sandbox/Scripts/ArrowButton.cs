// ----------------------------------------------------------------------------------------------------------
// Author: Austin Peel
//
// © All rights reserved. ECOLE POLYTECHNIQUE FEDERALE DE LAUSANNE, Switzerland, Section de Physique, 2024.
// See the LICENSE.md file for more details.
// ----------------------------------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ArrowButton : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Sprite open;
    [SerializeField] private Sprite close;

    private void OnEnable()
    {
        icon = GetComponent<Image>();
    }

    public void SetSprite(bool isOpen)
    {
        if (isOpen)
            icon.sprite = close;
        else
            icon.sprite = open;
    }
}
