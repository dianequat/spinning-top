// ----------------------------------------------------------------------------------------------------------
// Author: Austin Peel
//
// © All rights reserved. ECOLE POLYTECHNIQUE FEDERALE DE LAUSANNE, Switzerland, Section de Physique, 2024.
// See the LICENSE.md file for more details.
// ----------------------------------------------------------------------------------------------------------
using Slides;
using UnityEngine;

public class TopSimulationSlideController : SimulationSlideController
{
    [SerializeField] private bool startPaused;

    public override void InitializeSlide()
    {
        if (simulation && startPaused) simulation.Pause();
    }
}
