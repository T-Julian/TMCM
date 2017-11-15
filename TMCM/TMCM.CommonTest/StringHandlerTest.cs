﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMCM.Common;

namespace TMCM.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "BlogPage";
            var expected = "Blog Page";


            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            var source = "BlogPage";
            var expected = "Blog Page";


            // Act
            var actual = source.InsertSpaces();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
