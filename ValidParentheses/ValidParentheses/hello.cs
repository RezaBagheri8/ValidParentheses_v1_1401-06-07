public class Solution
{
    public bool IsValid(string s)
    {

        Stack<char> a = new Stack<char>();


        if (s.Length % 2 != 0)
        {
            return false;
        }
        for (int i = 0; i < s.Length; i++)
        {

            var c = s[i];
            if (s[i] != ']' && s[i] != ')' && s[i] != '}')
            {
                a.Push(s[i]);
            }
            else if (a.Count != 0)
            {
                var peek = a.Peek();
                if (s[i] == ')' && peek == '(')
                {
                    a.Pop();
                }
                else if (s[i] == ']' && peek == '[')
                {
                    a.Pop();
                }
                else if (s[i] == '}' && peek == '{')
                {
                    a.Pop();
                }
                else
                {
                    return false;
                }
            }
            else if (s[i] == ']' || s[i] == ')' || s[i] == '}')
            {
                return false;
            }
        }

        if (a.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
