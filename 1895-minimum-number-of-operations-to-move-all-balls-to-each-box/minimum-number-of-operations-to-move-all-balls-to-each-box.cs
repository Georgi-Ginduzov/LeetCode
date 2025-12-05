public class Solution {
    public int[] MinOperations(string boxes) {
        int movesLeft = 0, movesRight = 0;
        int boxesLeft = 0, boxesRight = 0;
        var operations = new int[boxes.Length];
        for(int i = 0; i < boxes.Length; i++)
        {
            operations[i] += movesLeft;
            boxesLeft += boxes[i] - '0';
            movesLeft += boxesLeft;

            var otherSideIndex = boxes.Length - 1 - i;
            operations[otherSideIndex] += movesRight; 
            boxesRight += boxes[otherSideIndex] - '0';
            movesRight += boxesRight;
        }

        return operations;
    }
}