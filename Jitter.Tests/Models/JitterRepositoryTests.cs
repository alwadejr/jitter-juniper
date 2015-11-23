using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jitter.Models;
using System.Collections.Generic;

namespace Jitter.Tests.Models
{
    [TestClass]
    public class JitterRepositoryTests
    {
        [TestMethod]
        public void JitterContextEnsureICanCreateInstance()
        {
            JitterContext context = new JitterContext();
            Assert.IsNotNull(context);
        }


        [TestMethod]
        public void JitterRepositoryEnsureICanCreateInstance()
        {
            JitterRepository repository = new JitterRepository();
            Assert.IsNotNull(repository);

        }

        [TestMethod]
        public void JitterRepositoryEnsureICanGetAllUsers()
        {
            JitterRepository repository = new JitterRepository();

            var expected = new List<JitterUser>
            {
                new JitterUser { Handle = "adam1" },
                new JitterUser { Handle = "rumbadancer2" }
            };


            var actual = repository.GetAllUsers();


            CollectionAssert.AreEqual(expected, actual.First().Handle);
            
        }

        [TestMethod]
        public void JitterRepositoryEnsueICanHaveAContext()
        {
            JitterRepository repository = new JitterRepository();

            var actual = repository.Context;

            Assert.IsInstanceOfType(actual, typeof(JitterContext));
        }
    }
}
