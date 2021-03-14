﻿// -----------------------------------------------------------------
// <copyright file="WalkPlanState.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Definitions.Enumerations
{
    /// <summary>
    /// Enumeration of the possible states of a walk plan.
    /// </summary>
    public enum WalkPlanState
    {
        /// <summary>
        /// The plan is to continue, and there is no need to recalculate the path.
        /// </summary>
        OnTrack,

        /// <summary>
        /// The plan can continue, but the path should be recalculated.
        /// </summary>
        NeedsToRecalculate,

        /// <summary>
        /// The plan was successfully traversed and we're at the goal location (for now).
        /// </summary>
        AtGoal,

        /// <summary>
        /// The plan was aborted.
        /// </summary>
        Aborted,
    }
}
