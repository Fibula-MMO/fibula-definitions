// -----------------------------------------------------------------
// <copyright file="ChatChannelType.cs" company="2Dudes">
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
    /// Enumerates the chat channel types.
    /// </summary>
    public enum ChatChannelType : ushort
    {
        /// <summary>
        /// The default game channel.
        /// </summary>
        Default,

        /// <summary>
        /// A channel that appears when rule violations are being reported.
        /// </summary>
        RuleViolations,

        /// <summary>
        /// A channel for trades.
        /// </summary>
        Trade,

        /// <summary>
        /// The real-life channel.
        /// </summary>
        RealLife,

        /// <summary>
        /// The help channel.
        /// </summary>
        Help,

        /// <summary>
        /// A private chat channel.
        /// </summary>
        Private,
    }
}
