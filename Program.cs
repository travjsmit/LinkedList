//Linked-List

using Linked_List;

//Node nodeA = new Node();
//nodeA.Data = 865;

//Node nodeB = new Node();
//nodeB.Data = 344;

//Node nodeC = new Node(); 
//nodeC.Data = 888;

//Node nodeD = new Node();
//nodeD.Data = 222;

//nodeA.Next = nodeB;
//nodeB.Next = nodeC;
//nodeC.Next = nodeD;
//nodeD.Next = nodeA;

LinkedList linkedList = new LinkedList();
linkedList.InsertHead(1);
linkedList.InsertHead(2);
linkedList.InsertHead(3);
linkedList.InsertHead(4);

linkedList.DeleteHead();
linkedList.DeleteHead();

linkedList.InsertLast(546);
linkedList.InsertLast(3434);

linkedList.DisplayList();
