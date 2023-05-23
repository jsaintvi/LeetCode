public class MovingAverage {

    private readonly Queue q;
    private readonly int _size;
    private int sum = 0;
    public MovingAverage(int size) {
        _size = size;
        q  = new Queue();
    }
    
    public double Next(int val) {
        q.Enqueue(val);

        return ComputeAverage(val);

    }

    private double ComputeAverage(int val)
    {
        if(q.Count > _size)
        {
            sum -= (int)q.Dequeue();
        }

        // update sum 
        sum += val;
        return (1.0 *  sum) / q.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */