using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    [TestFixture]
    internal class CustomerNUnitTest
    {
        [Test]
        public void FullName_ReturnFullName()
        {
            //1. Arrange
            Customer customer = new Customer()
            {
                FirstName = "John" ,
                LastName = "Doe"
            };

            //2. act
            string result = customer.FullName;

            //3. assert
            Assert.That(result, Is.Not.WhiteSpace);
            Assert.That(result, Does.Contain(" "));
            Assert.That(result, Does.Contain("John"));
            Assert.That(result, Does.Contain("Doe"));
            Assert.That(result, Does.StartWith("John"));
            Assert.That(result, Does.EndWith("Doe"));
            Assert.That(result, Is.EqualTo("John Doe"));
            Assert.That(result, Is.EqualTo("John Doe").IgnoreCase);
        }
    }
}
