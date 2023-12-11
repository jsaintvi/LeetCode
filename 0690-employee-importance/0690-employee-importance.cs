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
                
        var employeeMap = new Dictionary<int, Employee>();
        
        foreach(var employee in employees)
            employeeMap.Add(employee.id, employee);
        
        return DFS(id, employeeMap);
    }
    
    private int DFS(int eId, Dictionary<int, Employee> map) {
        Employee employee = map[eId];
        
        int ans = employee.importance;
        
        foreach(var subordinate in employee.subordinates) {
            ans+= DFS(subordinate, map);
        }
        
        return ans;
    }
}