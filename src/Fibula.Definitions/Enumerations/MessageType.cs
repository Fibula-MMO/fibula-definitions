// -----------------------------------------------------------------
// <copyright file="MessageType.cs" company="2Dudes">
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
    /// Enumeration of the possible message types in the game.
    /// </summary>
    public enum MessageType : byte
    {
        /// <summary>
        /// White message centered in the game window, and shown in the console.
        /// </summary>
        CenterWhite,
        
        /// <summary>
        /// Green message centered in the game window, and shown in the console.
        /// </summary>
        CenterGreen,

        /// <summary>
        /// Red message centered in the game window, and shown in the console.
        /// </summary>
        CenterRed,

        /// <summary>
        /// White message at the bottom of the game window, and shown in the console.
        /// </summary>
        Status,

        /// <summary>
        /// White message at the bottom of the game window.
        /// </summary>
        StatusNoConsole,

        /// <summary>
        /// Blue message shown only in the console.
        /// </summary>
        ConsoleOnlyBlue,

        /// <summary>
        /// Red message shown only in the console.
        /// </summary>
        ConsoleOnlyRed,

        /// <summary>
        /// Yellow message shown only in the console.
        /// </summary>
        ConsoleOnlyYellow,

        /// <summary>
        /// Light blue message shown only in the console.
        /// </summary>
        ConsoleOnlyLightBlue,

        /// <summary>
        /// Orange message shown only in the console.
        /// </summary>
        ConsoleOnlyOrange,
    }
}
