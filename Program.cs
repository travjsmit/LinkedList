//Linked-List

using LinkedList;

Node nodeA = new Node();
nodeA.Data = 865;

Node nodeB = new Node();
nodeB.Data = 344;

Node nodeC = new Node(); 
nodeC.Data = 888;

Node nodeD = new Node();
nodeD.Data = 222;

nodeA.Next = nodeB;
nodeB.Next = nodeC;
nodeC.Next = nodeD;
nodeD.Next = nodeA;

