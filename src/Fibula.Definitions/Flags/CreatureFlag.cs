﻿// -----------------------------------------------------------------
// <copyright file="CreatureFlag.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Definitions.Flags
{
    /// <summary>
    /// Enumerates all known creature flags.
    /// </summary>
    public enum CreatureFlag
    {
        /// <summary>
        /// The creature attempts to clear it's path by pushing movable items or destroying them.
        /// </summary>
        CanPushItems = 1 << 1,

        /// <summary>
        /// The creature attempts to clear it's path by pushing other creatures.
        /// </summary>
        CanPushCreatures = 1 << 2,

        /// <summary>
        /// The creature cannot be pushed by others.
        /// </summary>
        CannotBePushed = 1 << 3,

        /// <summary>
        /// The creature cannot be targetted for attack.
        /// </summary>
        CannotBeTargetted = 1 << 4,

        /// <summary>
        /// The creature keeps their distance when fighting.
        /// </summary>
        // TODO: will be removed in favor of an attribute.
        KeepsDistance = 1 << 5,
    }
}
