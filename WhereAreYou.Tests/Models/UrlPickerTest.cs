using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using WhereAreYou.Models;

namespace WhereAreYou.Tests.Models {
    [TestFixture]
    public class UrlPickerTest
    {
        [Test]
        public void Returns_AAAA_When_Given_Id_0()
        {
            Assert.AreEqual("AAAA", UrlPicker.Encode(0));
        }
    }
}