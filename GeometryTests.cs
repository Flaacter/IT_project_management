/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

using System;
using NUnit.Framework;
using Geometry;

namespace Geometry.Tests
{

    [TestFixture]
    public class GeometryTests
    {
        [Test]
        public void GetLength_ZeroVector_ReturnsZero()
        {
            // Arrange
            var zeroVector = new Vector { X = 0, Y = 0 };

            // Act
            var result = Geometry.GetLength(zeroVector);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GetLength_NonZeroVector_ReturnsCorrectLength()
        {
            // Arrange
            var vector = new Vector { X = 3, Y = 4 };

            // Act
            var result = Geometry.GetLength(vector);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        

        [Test]
        public void Add_WithNegativeCoordinates_ReturnsCorrectSum()
        {
            // Arrange
            var v1 = new Vector { X = -1, Y = -2 };
            var v2 = new Vector { X = 3, Y = 4 };

            // Act
            var result = Geometry.Add(v1, v2);

            // Assert
            Assert.That(result.X, Is.EqualTo(2));
            Assert.That(result.Y, Is.EqualTo(2));
        }

        [Test]
        public void GetLength_VectorWithNegativeCoordinates_ReturnsPositiveLength()
        {
            // Arrange
            var vector = new Vector { X = -3, Y = -4 };

            // Act
            var result = Geometry.GetLength(vector);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
