/*
// Definition for Employee.
class Employee {
    public int id;
    public int importance;
    public IList<int> subordinates;
}
*/

class Solution {
    private Dictionary<int, Employee> employees;
    
    public int GetImportance(IList<Employee> employees, int id) {
        this.employees = new Dictionary<int, Employee>();
        foreach (var employee in employees) {
            this.employees.Add(employee.id, employee);
        }
        return CalculateTotalImportance(id);
    }
    
    private int CalculateTotalImportance(int id) {
        if (!employees.ContainsKey(id)) {
            return 0;
        }
        var employee = employees[id];
        int totalImportance = employee.importance;
        foreach (var subId in employee.subordinates) {
            totalImportance += CalculateTotalImportance(subId);
        }
        return totalImportance;
    }
}