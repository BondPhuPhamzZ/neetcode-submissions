public class MyQueue {

    private Stack<int> stack1;
    private Stack<int> stack2;

    public MyQueue() {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    
    public void Push(int x) {
        stack1.Push(x);
    }
    
    public int Pop() {
        while (stack1.Count > 1)
        {
            stack2.Push(stack1.Pop());
        }
        
        int res = stack1.Pop();
        while (stack2.Count > 0)
        {
            stack1.Push(stack2.Pop());
        }
        return res;
    }
    
    public int Peek() {
        while (stack1.Count > 1)
        {
            stack2.Push(stack1.Pop());
        }
        
        int res = stack1.Peek();
        while (stack2.Count > 0)
        {
            stack1.Push(stack2.Pop());
        }
        return res;
    }
    
    public bool Empty() {
        return stack1.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */