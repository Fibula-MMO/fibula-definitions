// -----------------------------------------------------------------
// <copyright file="CharacterStat.cs" company="2Dudes">
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
    /// Enumerates the different character stats.
    /// </summary>
    public enum CharacterStat : byte
    {
        /// <summary>
        /// The hit points of a character.
        /// </summary>
        HitPoints,

        /// <summary>
        /// The mana points of a character.
        /// </summary>
        ManaPoints,

        /// <summary>
        /// The carry strength of a character.
        /// </summary>
        CarryStrength,

        /// <summary>
        /// The base speed of a character.
        /// </summary>
        BaseSpeed,
    }
}
