public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        // sort meetings by start time
        int n = intervals.Length;
        
        if(n == 0) return 0;
        
        Array.Sort(intervals, (x,y)=> x[0] - y[0] );
        // min heap (to track which meeting wil lend sooner and see if that can be used, else new room is allocated as the oother meetings are still undergoing)
        PriorityQueue<int,int> pq = new(); // we care about the end time to decide whether we can use that room or not
        
        for(int i = 0; i < n; i++ ) {
            var currMeetingStartTime = intervals[i][0];
            var currMeetingEndTime = intervals[i][1];
            if(pq.Count == 0) {
                pq.Enqueue(currMeetingEndTime, currMeetingEndTime);
            }else{
                // If the room due to free up the earliest is free, assign that room to this meeting.
                if(pq.Peek() <= currMeetingStartTime) {
                    pq.Dequeue();
                }
                
                pq.Enqueue(currMeetingEndTime, currMeetingEndTime);
            }
        }
        return pq.Count;
    }
}