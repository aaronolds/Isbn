using System.Reflection;
// <copyright file="ProgramTest.cs">Copyright ©  2018</copyright>
using System;
using System.Security.Policy;
using Isbn;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Isbn.Tests
{
    /// <summary>This class contains parameterized unit tests for Program</summary>
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProgramTest
    {

        [PexMethod(MaxRunsWithoutNewTests = 200)]
        [PexMethodUnderTest("Isbn13Checksum(String)")]
        internal string Isbn13Checksum(string isbn)
        {
            object[] args = new object[1];
            args[0] = (object)isbn;
            Type[] parameterTypes = new Type[1];
            parameterTypes[0] = typeof(string);
            string result0 = ((MethodBase)(typeof(Program).GetMethod("Isbn13Checksum",
                                                                     BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic, (Binder)null,
                                                                     CallingConventions.Standard, parameterTypes, (ParameterModifier[])null)))
                                 .Invoke((object)null, args) as string;
            string result = result0;
            return result;
            // TODO: add assertions to method ProgramTest.Isbn13Checksum(String)
        }


        [TestMethod]
        public void TestABC()
        {
            var x = Isbn13Checksum("978817525766");
            Assert.AreEqual(5, x);
        }
    }
}
