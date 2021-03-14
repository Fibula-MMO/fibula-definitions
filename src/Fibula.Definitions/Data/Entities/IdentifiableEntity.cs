// -----------------------------------------------------------------
// <copyright file="IdentifiableEntity.cs" company="2Dudes">
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
    /// <summary>
    /// Abstract class that represents the base of all entities that are identifiable by a single id.
    /// </summary>
    public abstract class IdentifiableEntity : BaseEntity
    {
        /// <summary>
        /// Gets or sets the id of this entity.
        /// </summary>
        public string Id { get; set; }
    }
}
