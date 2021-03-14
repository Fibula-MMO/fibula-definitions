﻿// -----------------------------------------------------------------
// <copyright file="ItemTypeEntity.cs" company="2Dudes">
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
    using System;
    using System.Collections.Generic;
    using Fibula.Definitions.Enumerations;
    using Fibula.Definitions.Flags;

    /// <summary>
    /// Class that represents an item type entity.
    /// </summary>
    public class ItemTypeEntity : BaseEntity, ICloneable
    {
        /// <summary>
        /// The id of the type of this item.
        /// </summary>
        private ushort typeId;
        private string name;
        private string description;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemTypeEntity"/> class.
        /// </summary>
        public ItemTypeEntity()
        {
            this.TypeId = 0;
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.DefaultAttributes = new Dictionary<byte, IConvertible>();
            this.Locked = false;
        }

        /// <summary>
        /// Gets or sets the id of the type of this item.
        /// </summary>
        public ushort TypeId
        {
            get => this.typeId;

            set
            {
                if (this.Locked)
                {
                    throw new InvalidOperationException($"Unable to set {nameof(this.TypeId)}. The {nameof(ItemTypeEntity)} is locked and cannot be altered.");
                }

                this.typeId = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of this type of item.
        /// </summary>
        public string Name
        {
            get => this.name;

            set
            {
                if (this.Locked)
                {
                    throw new InvalidOperationException($"Unable to set {nameof(this.Name)}. The {nameof(ItemTypeEntity)} is locked and cannot be altered.");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the decription of this type of item.
        /// </summary>
        public string Description
        {
            get => this.description;

            set
            {
                if (this.Locked)
                {
                    throw new InvalidOperationException($"Unable to set {nameof(this.Description)}. The {nameof(ItemTypeEntity)} is locked and cannot be altered.");
                }

                this.description = value.Trim('"');
            }
        }

        /// <summary>
        /// Gets the flags for this type of item.
        /// </summary>
        /// <remarks>The flags are stored as bits in a 64 bit unsigned integer.</remarks>
        public ulong Flags { get; private set; }

        /// <summary>
        /// Gets the attributes of this type of item.
        /// </summary>
        public IDictionary<byte, IConvertible> DefaultAttributes { get; }

        /// <summary>
        /// Gets a value indicating whether this item type is locked and no longer accepting changes.
        /// </summary>
        public bool Locked { get; private set; }

        /// <summary>
        /// Gets the client id of the type of this item.
        /// </summary>
        public ushort ClientId => this.HasItemFlag(ItemFlag.IsDisguised) ? Convert.ToUInt16(this.DefaultAttributes[(byte)ItemAttribute.DisguiseAs]) : this.TypeId;

        /// <summary>
        /// Locks the type, preventing it from accepting changes.
        /// </summary>
        public void LockChanges()
        {
            this.Locked = true;
        }

        /// <summary>
        /// Sets a flag in this type.
        /// </summary>
        /// <param name="itemFlag">The flag to set in the type.</param>
        public void SetItemFlag(ItemFlag itemFlag)
        {
            if (this.Locked)
            {
                throw new InvalidOperationException($"This ItemTypeEntity is locked and cannot be altered. {nameof(this.SetItemFlag)}({nameof(itemFlag)}={itemFlag}");
            }

            this.Flags |= (ulong)itemFlag;
        }

        /// <summary>
        /// Sets an attribute in this type.
        /// </summary>
        /// <param name="attribute">The attribute to set in the type.</param>
        /// <param name="attributeValue">The value of the attribute to set in the type.</param>
        public void SetAttribute(ItemAttribute attribute, int attributeValue)
        {
            if (this.Locked)
            {
                throw new InvalidOperationException($"This ItemTypeEntity is locked and cannot be altered. {nameof(this.SetAttribute)}({nameof(attribute)}={attribute},{nameof(attributeValue)}={attributeValue}");
            }

            this.DefaultAttributes[(byte)attribute] = attributeValue;
        }

        /// <summary>
        /// Clones the <see cref="ItemTypeEntity"/> into a new instance without locking the clone.
        /// </summary>
        /// <returns>The cloned <see cref="ItemTypeEntity"/>.</returns>
        public object Clone()
        {
            var newInstance = new ItemTypeEntity()
            {
                TypeId = this.typeId,
                Name = this.name,
                Description = this.description,
            };

            newInstance.Flags = this.Flags;

            foreach (var attribute in this.DefaultAttributes)
            {
                newInstance.DefaultAttributes.Add(attribute);
            }

            return newInstance;
        }

        /// <summary>
        /// Checks if the item type has the given item flag set.
        /// </summary>
        /// <param name="itemFlag">The item flag to check for.</param>
        /// <returns>True if the item type has the item flag set, and false otherwise.</returns>
        public bool HasItemFlag(ItemFlag itemFlag)
        {
            return (this.Flags & (ulong)itemFlag) == (ulong)itemFlag;
        }
    }
}
