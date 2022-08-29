using ValidParentheses;

Validator validator = new Validator();

bool result = validator.IsValid("()({}[])[]{}");

Console.WriteLine(result);

