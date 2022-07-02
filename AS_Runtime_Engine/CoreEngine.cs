namespace AS_Runtime_Engine
{
    public class CoreEngine
    {
        private static List<Variable> _variables;
        static CoreEngine()
        {
            // Check if static needed
            _variables = new List<Variable>();
        }
        public static string Eval(string term1, string term2, char op)
        {
            switch (op)
            {
                case '+':
                    return (int.Parse(term1) + int.Parse(term2)).ToString();
                case '-':
                    return (int.Parse(term1) - int.Parse(term2)).ToString();
                case '*':
                    return (int.Parse(term1) * int.Parse(term2)).ToString();
                case '/':
                    return (int.Parse(term1) + int.Parse(term2)).ToString();
                default:
                    return "Operation Error";
            }
        }

        public static string MakeOrUpdateVar(string name, string value)
        {
            // If variable exists, update the value
            foreach (Variable variable in _variables)
            {
                if (variable.Name == name)
                {
                    variable.Value = value;
                    return "Variable Updated";
                }
            }
            // If variable did not exist then create a new one
            _variables.Add(new Variable(name, value));
            return "Variable Created";
        }
    }
}