// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
using System;
using System.Collections.Generic;
using QuickGraph.Unit;
using Microsoft.Pex.Framework.Generated;

namespace QuickGraph.Collections
{
    public partial class BinaryHeapTPriorityTValueEnumeratorTest
    {
        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void CurrentAfterMoveNextFinished01()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(1);
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(3, 4);
            this.CurrentAfterMoveNextFinished<int, int>(binaryHeap, s0);
        }

        [Test]
        [PexGeneratedBy(typeof(BinaryHeapTPriorityTValueEnumeratorTest))]
        public void CurrentAfterMoveNextFinished02()
        {
            BinaryHeap<int, int> binaryHeap;
            binaryHeap = BinaryHeapFactory.Create(0);
            KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(3, 4);
            this.CurrentAfterMoveNextFinished<int, int>(binaryHeap, s0);
        }

    }
}
