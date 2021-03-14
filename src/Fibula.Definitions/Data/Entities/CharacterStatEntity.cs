// -----------------------------------------------------------------
// <copyright file="CharacterStatEntity.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Definitions.Data.Entities
{
    using Fibula.Definitions.Enumerations;

    /// <summary>
    /// Class that represents a character stat entity.
    /// </summary>
    public class CharacterStatEntity : BaseEntity
    {
        /// <summary>
        /// Gets or sets the id of the character to which this stat belongs to.
        /// </summary>
        public string CharacterId { get; set; }

        /// <summary>
        /// Gets or sets the stat's type.
        /// </summary>
        public CharacterStat Type { get; set; }

        /// <summary>
        /// Gets or sets the maximum value that the stat can have.
        /// </summary>
        public uint Maximum { get; set; }

        /// <summary>
        /// Gets or sets the minimum value that the stat can have.
        /// </summary>
        public uint Minimum { get; set; }

        /// <summary>
        /// Gets or sets the default value that the stat takes if no current value is specified.
        /// </summary>
        public uint Default { get; set; }

        /// <summary>
        /// Gets or sets the current value of the stat.
        /// </summary>
        public uint Current { get; set; }
    }
}
