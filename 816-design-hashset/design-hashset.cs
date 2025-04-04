public class MyHashSet {
    private BitArray set;

    public MyHashSet() {
        set = new BitArray(1_000_001);
    }
    
    public void Add(int key) {
        set[key] = true;
    }
    
    public void Remove(int key) {
        set[key] = false;
    }
    
    public bool Contains(int key) {
        return set[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */