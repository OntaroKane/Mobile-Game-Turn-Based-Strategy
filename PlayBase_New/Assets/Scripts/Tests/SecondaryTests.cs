using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SecondaryTests
    {
        public int health;
        public GameObject go;

        // A Test behaves as an ordinary method
        [Test]
        public void SecondaryTestsSimplePasses()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(0,health);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SecondaryTestsWithEnumeratorPasses()
        {
            Assert.IsTrue(go.activeInHierarchy);
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
