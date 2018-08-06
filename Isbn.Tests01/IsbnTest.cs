// <copyright file="IsbnTest.cs">Copyright ©  2018</copyright>
using System;
using Isbn;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Isbn.Tests
{
    /// <summary>This class contains parameterized unit tests for Isbn</summary>
    [PexClass(typeof(global::Isbn.Isbn))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class IsbnTest
    {
        /// <summary>Test stub for Isbn13Checksum(String)</summary>
        [PexMethod(MaxRunsWithoutNewTests = 200)]
        public string Isbn13ChecksumTest([PexAssumeUnderTest]global::Isbn.Isbn target, string isbn)
        {
            string result = target.Isbn13Checksum(isbn);
            return result;
            // TODO: add assertions to method IsbnTest.Isbn13ChecksumTest(Isbn, String)
        }
    }
}
