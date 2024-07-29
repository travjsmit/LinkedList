Intro To Linked-List in C#

Structure and Components of a Linked List:
HEAD-->[NODE]-->[NODE]-->[NODE]-->[NODE]-->NULL
Node Class (contains two primary components):
1. Data: This stores the value or data of the node.
2. Next: This is a reference (or pointer) to the next node in the sequence.
LinkedList Class: This class manages the linked list as a whole. It typically includes methods for adding, removing, and searching for nodes. It also keeps track of the head (and sometimes the tail) of the list.
Head: The head pointer (or reference) points to the first node in the linked list. If the list is empty, the head is null.

Linked List Creation STEPS:
Insert
1. Create new node
2. Assign data to next field
3. Assign the head
4. O(1)

Delete
1. Assign a temporary variable
2. Assign a new head
3. Return a temporary variable
4. O(1)

Iterate
1. Assign a current node
2. Make a while loop
3. check current node is null

Differences between Linked Lists and Array Lists:
Traditional Arrays - fixed, middle insertion is not ideal // O(n) operation
Linked Lists - insert anywhere, dynamic

Challenges faced:
Lots of null warnings in Visual Studio. Though the video said it was common and related to .Net releases after .Net 6. Aside from that, I had to update the namespace from LinkedList to Linked_List, as it was causing issues.

Future uses:
Linked lists would be awesome in handling large data with frequent insertions and deletions, such as in flight data tracking apps. Where the updates to the lat/long position, speed, altitude, and heading of multiple aircraft are simultaneously occurring.
