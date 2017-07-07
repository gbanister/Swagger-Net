﻿using NUnit.Framework;
using Swashbuckle.Swagger.XmlComments;
using System;
using System.IO;
using System.Linq;

namespace Swashbuckle.Tests.CoreUnitTests
{
    [TestFixture]
    class ApplyXmlTypeCommentsTests
    {
        [Test]
        public void ApplyXmlTypeComments_Empty()
        {
            Assert.Throws<ArgumentException>(() => new ApplyXmlTypeComments(""));
        }

        [Test]
        public void ApplyXmlTypeComments_Test()
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            string xmlFile = Directory.GetFiles(directory, "*.XML", SearchOption.AllDirectories).FirstOrDefault();
            if (string.IsNullOrEmpty(xmlFile))
            {
                Assert.Inconclusive();
            }
            else
            {
                Assert.DoesNotThrow(() => new ApplyXmlTypeComments(xmlFile));
            }
        }
    }
}