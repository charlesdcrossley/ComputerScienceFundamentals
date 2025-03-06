using DataStructures.LinkedList;
using System.Text;

namespace DataStructures.Test.LinkedLists
{
    [TestClass]
    public sealed class SinglyLinkedListTests
    {
        [TestMethod]
        public void AddFirst_WhenNodeAdded_NodeIsFirstPositionInList()
        {
            // Arrange 
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            Node<int> testNode = new Node<int>(5);

            // Act 
            list.InsertFirst(testNode);

            // Assert
            Assert.AreEqual(list.Head, testNode);
            Assert.AreEqual(list.Head.Value, 5);

        }
        [TestMethod]

        public void AddFirst_WhenNodeAdded_CountIsAccurate()
        {
            // Arrange
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            Node<int> testNode1 = new Node<int>(2);
            Node<int> testNode2 = new Node<int>(3);
            Node<int> testNode3 = new Node<int>(5);

            // Act 
            list.InsertFirst(testNode1);
            list.InsertFirst(testNode2);
            list.InsertFirst(testNode3);

            // Assert 
            Assert.AreEqual(list.Count, 3);

        }
        [TestMethod]
        public void DisplayList_WhenCalled_OutputsList()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            SinglyLinkedList<string> stringList = new SinglyLinkedList<string>();

            stringList.InsertFirst(new Node<string>("third"));
            stringList.InsertFirst(new Node<string>("second"));
            stringList.InsertFirst(new Node<string>("first"));

            var expectedOutput = new StringBuilder();
            expectedOutput.AppendLine("first").AppendLine("second").AppendLine("third");

            // Act 
            stringList.DisplayListConsole();
            
            // Assert
            Assert.AreEqual(expectedOutput.ToString(), writer.ToString());
            
        }
    }
}
