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
        [Test]
        public void Returns_AAAB_When_Given_Id_1()
        {
            Assert.AreEqual("AAAB", UrlPicker.Encode(1));
        }
        [Test]
        public void Returns_AAA9_When_Given_Id_57()
        {
            Assert.AreEqual("AAA9", UrlPicker.Encode(57));
        }
        [Test]
        public void Returns_AABA_When_Given_Id_58()
        {
            Assert.AreEqual("AABA", UrlPicker.Encode(58));
        }
        [Test]
        public void Returns_AA99_When_Given_Id_3363()
        {
            Assert.AreEqual("AA99", UrlPicker.Encode(3363));
        }
        [Test]
        public void Returns_ABAA_When_Given_Id_3364()
        {
            Assert.AreEqual("ABAA", UrlPicker.Encode(3364));
        }
        [Test]
        public void Returns_9999_When_Given_Id_11316495()
        {
            Assert.AreEqual("9999", UrlPicker.Encode(11316495));
        }
        [Test]
        public void Returns_OverFlow_Error_When_Given_Id_11316496()
        {
            Assert.Throws<OverflowException>(() => UrlPicker.Encode(11316496));
        }
    }
}