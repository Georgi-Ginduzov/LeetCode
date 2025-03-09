public class Solution {    
    public int[] KWeakestRows(int[][] mat, int k) {
        var rowsPower = new Dictionary<int, int>(mat.Length);
        for(int i = 0; i < mat.Length; i++)
        {
            int low = 0;
            int high = mat[i].Length-1;
            int lastIndexOfOne = -1;
            while(low <= high)
            {
                int mid = low + (high-low)/2;
                if(mat[i][mid]==1)
                {
                    lastIndexOfOne = mid;
                    low = mid+1;
                }
                else
                {
                    high = mid-1;
                }
            }
            rowsPower[i] = lastIndexOfOne + 1;
        }
        int size = 0;
        int[] heap = new int[mat.Length + 1];

        foreach(var pair in rowsPower)
        {
            int i = size++;
            heap[i] = pair.Key;

            int parent = (i - 1)/2;
            while(i != 0 && rowsPower[heap[i]] <= rowsPower[heap[parent]])
            {
                if(rowsPower[heap[i]] == rowsPower[heap[parent]])
                {
                    if(heap[i] < heap[parent])
                    {
                        int temp = heap[i];
                        heap[i] = heap[parent];
                        heap[parent] = temp;
                    }
                }
                else
                {
                    int temp = heap[i];
                    heap[i] = heap[parent];
                    heap[parent] = temp;
                }

                i = parent;
                parent = (parent-1)/2;
            }
        }

        int[] result = new int[k];
        for(int i = 0; i < k; i++)
        {
            result[i] = heap[0];
            heap[0] = heap[--size];

            int current = 0;
            while (true)
            {
                int left = 2 * current + 1;
                int right = 2 * current + 2;
                int smallest = current;

                if (left < size && rowsPower[heap[left]] < rowsPower[heap[smallest]])
                {
                    smallest = left;
                }
                if (right < size && rowsPower[heap[right]] < rowsPower[heap[smallest]])
                {
                    smallest = right;
                }
                if (left < size && rowsPower[heap[left]] == rowsPower[heap[smallest]] && heap[left] < heap[smallest])
                {
                    smallest = left;
                }
                if (right < size && rowsPower[heap[right]] == rowsPower[heap[smallest]] && heap[right] < heap[smallest])
                {
                    smallest = right;
                }

                if (smallest == current)
                {
                    break;
                }

                int temp = heap[current];
                heap[current] = heap[smallest];
                heap[smallest] = temp;

                current = smallest;
            }
        }
        return result;
    }
}