/*
// Definition for Employee.
class Employee {
    public int id;
    public int importance;
    public IList<int> subordinates;
}
*/

class Solution {
    public int GetImportance(IList<Employee> employees, int id) {
        // find the emplyee with such id
        // loop thru its sbordinates and add to the total recursively
        
        int total = 0;
        
        var q = new Queue<int>();
        q.Enqueue(id);
        
        while(q.Count > 0) {
            var curr = q.Dequeue();
            var employee = employees.First(x => x.id == curr);
            
            total += employee.importance;
            
            if(employee.subordinates != null && employee.subordinates.Any())
                foreach(var subordinate in employee.subordinates)
                 q.Enqueue(subordinate);
        }
        return total;
    }
}