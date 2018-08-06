// <copyright file="IsbnTest.cs">Copyright ©  2018</copyright>

using System;
using Isbn;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Isbn.Tests
{
    [TestClass]
    [PexClass(typeof(global::Isbn.Isbn))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsbnTest
    {
    }
}
