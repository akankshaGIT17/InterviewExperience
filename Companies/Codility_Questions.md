Question 1
-------------

There are N players standing in a row, one player on a field. They are numbered from 0 to N−1 from left to right.
Players perform moves one by one from left to right, that is, in ascending order of numbers. Each player presses an arrow key in one of the four cardinal directions: left ('<'), right('>'),up('^') or dow('v'). A key press in the given direction means that the player attempts to move onto the closest field in the direction specified. A move can be performed only if there is no other player already standing on the target field.

Moves are represented as a string S of length N, where S[K] (for K within the range 0..N−1) is the direction of the K-th player's move. How many players will actually perform a move successfully?

Write a function that takes a string S, which, given a string S of length N representing arrow keys pressed by each of the players, returns the number of players that will perform a move successfully.

Test case 1
 Given S = "><^v", your function should return 2. Player 0 cannot move rightwards, because player 1 is standing on the target field. Player 1 cannot move leftwards, because player 0 is standing on the target field. Players 2 and 3 can both perform their moves because there are no other players standing on their target fields.

Test Case 2: Given S = "<<^<v>>", your function should return 6. Players 0, 1, 2, 3, 4 can all perform their moves because there are no other players standing on their target fields. Player 5 pressed the right-arrow key, but the move cannot be performed as player 6 is already standing on the target field. The move of player 6 can be performed, though, as there is no other player standing on the target field.

Test case 3. Given S = '><><'
   your function should return 0. No player can perform a move.

test with below test cases
 '><^v' output should be 2
'<<^<v>>' output should be 6	
  
Question 2
-----------
  An array A consisting of N integers is given. A slice	 of that array is a pair of integers (P, Q) such that 0 ≤ P ≤ Q < N. A slice (P, Q) of array A is called non-negative  if all the elements A[P], A[P+1], ..., A[Q−1], A[Q] are non-negative. The sum  of a slice (P, Q) of array A is the value A[P] + A[P+1] + ... + A[Q−1] + A[Q].
For example, the following array A:
A[0] =  1
  A[1] =  2
  A[2] = -3
  A[3] =  4
  A[4] =  5
  A[5] = -6

has non-negative slices (0, 0), (1, 1), (0, 1), (3, 3), (4, 4) and (3, 4).
 The sum of slice (0, 1) is A[0] + A[1] = 1 + 2 = 3.
 The sum of slice (3, 4) is A[3] + A[4] = 4 + 5 = 9.
 The sum of slice (4, 4) is A[4] = 5.


that, given an array A consisting of N integers, returns the maximum sum of any non-negative slice in this array.

 The function should return −1 if there are no non-negative slices in the array.


test cases
Test case 1 : given the following array A:
  A[0] =  1
  A[1] =  2
  A[2] = -3
  A[3] =  4
  A[4] =  5
  A[5] = -6

the function should return 4 + 5 = 9, as explained above. 


 Test case 2 : Given array A:

  A[0] = -8
  A[1] =  3
  A[2] =  0
  A[3] =  5
  A[4] = -3
  A[5] = 12

the function should return 12. 
                                                                                                                            
                                                                                                                            
 Question 3
 -----------
 There is an array A made of N integers. Your task is to choose as many integers from A as possible so that, when they are put in ascending order, all of the differences between all pairs of consecutive integers are equal.
For example, for A = [4, 3, 5, 1, 4, 4], you could choose 1, 3 and 5 (with differences equal to 2) or 4, 4 and 4 (with differences equal to 0).
What is the maximum number of integers that can be chosen?
Write a function in c# that, given an array A made of N integers, returns the maximum number of integers that can be chosen following the rules described above.

Examples:
1. For A = [4, 7, 1, 5, 3], the function should return 4. It is possible to choose four integers (7, 1, 5 and 3). When put in ascending order, the difference between all consecutive integers is 2.

2. For A = [12, 12, 12, 15, 10], the function should return 3. It is optimal to choose all integers with a value of 12.
3. For A = [18, 26, 18, 24, 24, 20, 22], the function should return 5. Five integers (18, 20, 22, 24, 26) can be chosen. Notice that we cannot pick any other integers, even though they occur more than once.
   
