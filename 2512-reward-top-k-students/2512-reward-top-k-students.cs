public class Solution {
    public IList<int> TopStudents(string[] positive_feedback, string[] negative_feedback, string[] report, int[] student_id, int k) {
        int n = student_id.Length;
        int [] overallFeedback = new int[n];
        
        var posFeedbackSet = new HashSet<string>(positive_feedback);
        var negFeedbackSet = new HashSet<string>(negative_feedback);
        
        for(int i = 0; i <  report.Length; i++)
        {
            var reportArr = report[i].Split(' ');
            
            foreach (var currWord in reportArr) {
                if(posFeedbackSet.Contains(currWord))
                    overallFeedback[i] += 3;
                
                if(negFeedbackSet.Contains(currWord))
                    overallFeedback[i] -= 1;
            }
        }
        
        PrintFeedback(overallFeedback);
        
        //Array.Sort(overallFeedback, new ScoreComparer());
//         Array.Sort(overallFeedback, new ScoreComparer());
        
//         List<int> ans = new();
//         for(int i = 0; i < k; i++)
//             ans.Add(student_id[i]);
        
        var pq = new PriorityQueue<ScoreInfo,ScoreInfo>(new ScoreComparer());
        
        for(int i = 0; i < overallFeedback.Length; i++) {
            var scoreInfo = new ScoreInfo(i, overallFeedback[i], student_id[i]);
            pq.Enqueue(scoreInfo, scoreInfo);
            
            // if(pq.Count > k)
            //     pq.Dequeue();
        }
        
        List<int> ans = new();
        int pos = 0;
        while(pq.Count > 0 && pos < k) {
            var score = pq.Dequeue();
            //Console.WriteLine($"Student Idx {score.Idx} with score {score.Score}");
            ans.Add(student_id[score.Idx]);
            pos += 1;
        }
        
        return ans;
    }
    
    private class ScoreComparer : IComparer<ScoreInfo> {
        public int Compare(ScoreInfo x, ScoreInfo y) {
            return y.Score == x.Score ? 
                x.StudentId.CompareTo(y.StudentId) 
                : y.Score.CompareTo(x.Score);
        }
    }
    
    private void PrintFeedback(int[] feedback)
    {
        Console.WriteLine("----------------PRINTING FEEDBACK--------------");
        for(int i = 0; i < feedback.Length; i++)
            Console.WriteLine($"Student {i}: {feedback[i]}");
        
        Console.WriteLine("----------------END----------------------------");
    }
    
    private class ScoreInfo
    {
        public int Idx {get;}
        public int Score {get;}
        public int StudentId {get;}
        
        public ScoreInfo(int idx, int score, int studentId){
            this.Idx = idx;
            this.Score = score;
            this.StudentId = studentId;
        }
    }
}