public class Solution {
    public IList<int> TopStudents(string[] positive_feedback, string[] negative_feedback, string[] report, int[] student_id, int k) {
        int n = student_id.Length;
        ScoreInfo [] overallFeedback = new ScoreInfo[n];
        for(int i = 0; i < n; i++)
        {
            overallFeedback[i] = new ScoreInfo(i, 0, student_id[i]);
        }
        
        var posFeedbackSet = new HashSet<string>(positive_feedback);
        var negFeedbackSet = new HashSet<string>(negative_feedback);
        
        for(int i = 0; i <  report.Length; i++)
        {
            var reportArr = report[i].Split(' ');
            
            foreach (var currWord in reportArr) {
                if(posFeedbackSet.Contains(currWord))
                    overallFeedback[i].Score += 3;
                
                if(negFeedbackSet.Contains(currWord))
                    overallFeedback[i].Score -= 1;
            }
        }
        
        
        
        Array.Sort(overallFeedback, (x,y) =>{
            return y.Score == x.Score ? 
                x.StudentId.CompareTo(y.StudentId) 
                : y.Score.CompareTo(x.Score);
        });
        
        // PrintFeedback(overallFeedback);
        
        List<int> ans = new();
        for(int i = 0; i < k; i++)
            ans.Add(overallFeedback[i].StudentId);
        
        
        return ans;
    }
    
    
    private void PrintFeedback(ScoreInfo[] feedback)
    {
        Console.WriteLine("----------------PRINTING FEEDBACK--------------");
        for(int i = 0; i < feedback.Length; i++)
        {
            var studentFeedback = feedback[i];
            Console.WriteLine($"Student {studentFeedback.StudentId}: {studentFeedback.Score}");
        }
        
        Console.WriteLine("----------------END----------------------------");
    }
    
    private class ScoreInfo
    {
        public int Idx {get;}
        public int Score {get; set;}
        public int StudentId {get;}
        
        public ScoreInfo(int idx, int score, int studentId){
            this.Idx = idx;
            this.Score = score;
            this.StudentId = studentId;
        }
    }
}