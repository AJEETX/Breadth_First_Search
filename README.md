# Breadth_First_Search

> The very first thing to understand is the meaning of breadth first search itself.
> 

It means that first the search is done just beside the current location or we may call it node. 

One by one all the adjacent nodes are found and are marked so that they are not searched again. Since full search is done on just beside nodes (adjacent locations) hence called full breadth of the current location is searched. Thus the search is exhaustive.


### Scenario

##### Given:
>   1. Chessboard game 
   
>   The chessboard has a size of given length x breadth of N x N (normal chess board is of 8 x8).
   
>   Knight is placed on chessboard on any given valid location.
   
>   Knight can move 2 and a half space in 1 step. (the normal movement of knight is 2 space in any linear direction plus 1 space perpendicular to the moved direction )
   
>   The knight is required to reach at any given valid location on the chessboard.
   
>   The knight should reach the destination location with minimum possible steps.


#### Solution

The algorithm finds the minimum number of steps required for the knight from a given source location to a given destination location.



