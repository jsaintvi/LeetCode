public class Solution {
    public string[] GetFolderNames(string[] names) {
        Dictionary<string, int> seenNames = new Dictionary<string, int>();
        List<string> result = new List<string>();

        foreach (var name in names) {
            if (!seenNames.ContainsKey(name)) {
                seenNames[name] = 1;
                result.Add(name);
            } else {
                int count = seenNames[name];
                string newName = $"{name}({count})";

                while (seenNames.ContainsKey(newName)) {
                    count++;
                    newName = $"{name}({count})";
                }

                seenNames[name] = count + 1;
                seenNames[newName] = 1;
                result.Add(newName);
            }
        }

        return result.ToArray();
    }
}