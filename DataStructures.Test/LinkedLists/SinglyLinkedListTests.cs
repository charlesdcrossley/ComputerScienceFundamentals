using DataStructures.LinkedList;

namespace DataStructures.Test.LinkedLists
{
    [TestClass]
    public sealed class SinglyLinkedListTests
    {
        [TestMethod]
        public void AddFirst_WhenNodeAdded_NodeIsFirstPositionInList()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            Node<int> testNode = new Node<int>(5);

            list.AddFirst(testNode);

            Assert.AreEqual(list.Head, testNode);
            Assert.AreEqual(list.Head.Value, 5);

        }
        [TestMethod]

        public void AddFirst_WhenNodeAdded_CountIsAccurate()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            Node<int> testNode1 = new Node<int>(2);
            Node<int> testNode2 = new Node<int>(3);
            Node<int> testNode3 = new Node<int>(5);

            list.AddFirst(testNode1);
            list.AddFirst(testNode2);
            list.AddFirst(testNode3);

            Assert.AreEqual(list.Count, 3);

        }
    }
}
