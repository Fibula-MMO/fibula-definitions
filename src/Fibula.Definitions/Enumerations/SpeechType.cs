// -----------------------------------------------------------------
// <copyright file="SpeechType.cs" company="2Dudes">
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
    /// Enumeration of the possible speech types.
    /// </summary>
    public enum SpeechType : byte
    {
        /// <summary>
        /// A normal talk.
        /// </summary>
        Normal,

        /// <summary>
        /// Whispering (#w).
        /// </summary>
        Whisper,

        /// <summary>
        /// Yelling (#y).
        /// </summary>
        Yell,

        /// <summary>
        /// Players speaking privately to other players.
        /// </summary>
        Private,

        /// <summary>
        /// Rule violation report.
        /// </summary>
        RuleViolationReport,

        /// <summary>
        /// Rule violation reply.
        /// </summary>
        RuleViolationAnswer,

        /// <summary>
        /// Rule violation continuance.
        /// </summary>
        RuleViolationContinue,

        /// <summary>
        /// Broadcast a message (#b).
        /// </summary>
        Broadcast,

        /// <summary>
        /// Yellow message in chat.
        /// </summary>
        ChannelYellow,

        /// <summary>
        /// Talk in organge.
        /// </summary>
        MonsterNormal,

        // ChannelRed = 0x05,   //Talk red on chat - #c
        // PrivateRed = 0x04,   //Red private - @name@ text
        // ChannelOrange = 0x05,    //Talk orange on text
        // ChannelRedAnonymous = 0x05,  //Talk red anonymously on chat - #d
        // MonsterYell = 0x0E,  //Yell orange
    }
}
