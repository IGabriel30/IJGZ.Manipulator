using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJGZ.Manipulator.AppxUnit
{
    public class StringManipulatorTests
    {
        [Fact] 
        public void ReverseString_ShouldReturnReversedString() //verifica se invierte correctamente una cadena normal
        {
            StringManipulator manipularString = new StringManipulator();
            // Arrange
            string input = "hello";
            string expected = "olleh";

            // Act
            string result = manipularString.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void RemoveSpaces_ShouldRemoveAllSpaces()
        {
            // Arrange
            StringManipulator manipularString = new StringManipulator();
            string input = "H 3 l l o";
            string expected = "H3llo";

            // Act
            string result = manipularString.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void RemoveSpaces_WithEmptyString_ReturnsEmptyString() //vverifica que una cadena vacía retorne una cadena vacía
        {
            // Arrange
            StringManipulator manipularString = new StringManipulator();
            string input = "";
            string expected = "";

            // Act
            string result = manipularString.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }
       
    }
}
