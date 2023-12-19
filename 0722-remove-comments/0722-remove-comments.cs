public class Solution
{
    public IList<string> RemoveComments(string[] source)
    {
        List<string> result = new List<string>();
        bool block = false;
        StringBuilder line = new StringBuilder();

        foreach (string codeLine in source)
        {
            for (int i = 0; i < codeLine.Length; i++)
            {
                if (block)
                {
                    if (codeLine[i] == '*' && i + 1 < codeLine.Length && codeLine[i + 1] == '/')
                    {
                        block = false;
                        i++;
                    }
                }
                else
                {
                    if (codeLine[i] == '/' && i + 1 < codeLine.Length)
                    {
                        if (codeLine[i + 1] == '/')
                        {
                            break;
                        }
                        else if (codeLine[i + 1] == '*')
                        {
                            block = true;
                            i++;
                        }
                        else
                        {
                            line.Append(codeLine[i]);
                        }
                    }
                    else
                    {
                        line.Append(codeLine[i]);
                    }
                }
            }

            if (!block && line.Length > 0)
            {
                result.Add(line.ToString());
                line.Clear();
            }
        }

        if (!block && line.Length > 0)
        {
            result.Add(line.ToString());
        }

        return result;
    }
}