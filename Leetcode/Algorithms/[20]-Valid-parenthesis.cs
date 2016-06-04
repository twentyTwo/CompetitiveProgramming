public class Solution {
    public bool IsValid(string s) {
        var stringStack = new Stack<char>();
            foreach (var t in s)
            {
                if(t=='(' || t=='{' ||t=='[') stringStack.Push(t);

                else if ((t == ')' && stringStack.Count > 0 && stringStack.Peek().Equals('('))
                        || (t == '}' && stringStack.Count > 0 && stringStack.Peek().Equals('{'))
                        || (t == ']' && stringStack.Count > 0 && stringStack.Peek().Equals('[')))
                {
                    stringStack.Pop();
                }
                else
                {
                    return false;
                }              
            }

            return stringStack.Count == 0;
    }
}
