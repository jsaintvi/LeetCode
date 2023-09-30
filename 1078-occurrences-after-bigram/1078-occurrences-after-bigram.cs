public class Solution {
    public string[] FindOcurrences(string text, string first, string second) {
        var words = new LinkedList<string>(text.Split(" "));
        
        var node = words.First;
        var result = new List<string>();
        while (node.Next != null)
        {
            if(node.Value.Equals(first) && node.Next.Value.Equals(second) && node?.Next?.Next?.Value != null)
            {
                result.Add(node.Next.Next.Value);
            }
            node = node.Next;
        }
        return result.ToArray();
    }
}