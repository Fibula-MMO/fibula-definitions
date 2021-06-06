// -----------------------------------------------------------------
// <copyright file="Location.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Definitions.Data.Structures
{
    using System;
    using Fibula.Definitions.Constants;
    using Fibula.Definitions.Enumerations;

    /// <summary>
    /// Structure for all locations in the game.
    /// </summary>
    public struct Location
    {
        /// <summary>
        /// Gets or sets the value of this location in the X coordinate.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the value of this location in the Y coordinate.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets the value of this location in the Z coordinate.
        /// </summary>
        public sbyte Z { get; set; }

        /// <summary>
        /// Adds two <see cref="Location"/> values.
        /// </summary>
        /// <param name="location1">The first location.</param>
        /// <param name="location2">The second location.</param>
        /// <returns>The result of the operation.</returns>
        public static Location operator +(Location location1, Location location2)
        {
            return new Location
            {
                X = location1.X + location2.X,
                Y = location1.Y + location2.Y,
                Z = (sbyte)(location1.Z + location2.Z),
            };
        }

        /// <summary>
        /// Subtracts two <see cref="Location"/> values.
        /// </summary>
        /// <param name="location1">The first location.</param>
        /// <param name="location2">The second location.</param>
        /// <returns>The result of the operation.</returns>
        public static Location operator -(Location location1, Location location2)
        {
            return new Location
            {
                X = location2.X - location1.X,
                Y = location2.Y - location1.Y,
                Z = (sbyte)(location2.Z - location1.Z),
            };
        }

        /// <summary>
        /// Checks if two <see cref="Location"/> values are considered equal.
        /// </summary>
        /// <param name="location1">The first location.</param>
        /// <param name="location2">The second location.</param>
        /// <returns>True if they are equal, false otherwise.</returns>
        public static bool operator ==(Location location1, Location location2) => location1.X == location2.X && location1.Y == location2.Y && location1.Z == location2.Z;

        /// <summary>
        /// Checks if two <see cref="Location"/> values are considered equal.
        /// </summary>
        /// <param name="location1">The first location.</param>
        /// <param name="location2">The second location.</param>
        /// <returns>True if they are not equal, false otherwise.</returns>
        public static bool operator !=(Location location1, Location location2) => location1.X != location2.X || location1.Y != location2.Y || location1.Z != location2.Z;

        /// <summary>
        /// Checks if a <see cref="Location"/> is considered greater than <see cref="Location"/>.
        /// A <see cref="Location"/> is considered 'greater' than another when any of it's coordinates is greater than those of the other <see cref="Location"/>.
        /// </summary>
        /// <param name="location1">The first location.</param>
        /// <param name="location2">The second location.</param>
        /// <returns>True if <paramref name="location1"/> is considered greater than <paramref name="location2"/>.</returns>
        public static bool operator >(Location location1, Location location2) => location1.X > location2.X || location1.Y > location2.Y || location1.Z > location2.Z;

        /// <summary>
        /// Checks if a <see cref="Location"/> is considered lesser than <see cref="Location"/>.
        /// A <see cref="Location"/> is considered 'lesser' than another when any of it's coordinates is less than those of the other <see cref="Location"/>.
        /// </summary>
        /// <param name="location1">The first location.</param>
        /// <param name="location2">The second location.</param>
        /// <returns>True if <paramref name="location1"/> is considered lesser than <paramref name="location2"/>.</returns>
        public static bool operator <(Location location1, Location location2) => location1.X < location2.X || location1.Y < location2.Y || location1.Z < location2.Z;

        /// <summary>
        /// Gets this location's string representation: it's coordinates.
        /// </summary>
        /// <returns>This location's string representation.</returns>
        public override string ToString()
        {
            return $"[{this.X}, {this.Y}, {this.Z}]";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is Location other)
            {
                return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
            }

            return false;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.X, this.Y, this.Z);
        }
    }
}
