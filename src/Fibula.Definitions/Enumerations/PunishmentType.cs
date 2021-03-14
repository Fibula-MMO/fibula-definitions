// -----------------------------------------------------------------
// <copyright file="PunishmentType.cs" company="2Dudes">
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
    /// Enumeration of the possible types of punishments in the game.
    /// </summary>
    public enum PunishmentType : byte
    {
        /// <summary>
        /// No characters in an account will be unable to log in until the banishment end date.
        /// </summary>
        AccountBanisment,

        /// <summary>
        /// A character will be unable to log in until their name is changed.
        /// </summary>
        CharacterNameLock,

        /// <summary>
        /// A character will be unable to log in until the banishment end date.
        /// </summary>
        CharacterBanisment,
    }
}
