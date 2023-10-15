
public class Token
{
    public string Value { get; private set; }
    public TokenType Type { get; private set; }
    public CodeLocation Location { get; private set; }

    public Token(TokenType type, string value, CodeLocation location)
    {
        this.Type = type;
        this.Value = value;
        this.Location = location;
    }

    public override string ToString()
        => string.Format("{0} [{1}]", Type, Value);
}

public struct CodeLocation
{
    public string File;
    public int Line;
    public int Column;
}


public enum TokenType
{
    Number,
    Text,
    Keyword,
    Identifier,
    Symbol
}

public class TokenValues
{
    protected TokenValues() { }

    public const string Add = "Addition"; // +
    public const string Sub = "Subtract"; // -
    public const string Mul = "Multiplication"; // *
    public const string Div = "Division"; // /
    public const string Exp = "Exponentiation"; // ^ 

    public const string Assign = "Assign"; // =
    public const string LambdaExpression = "Lambda Expression"; // =>

    public const string ValueSeparator = "ValueSeparator"; // ,
    public const string StatementSeparator = "StatementSeparator"; // ;

    public const string OpenBracket = "OpenBracket"; // (
    public const string ClosedBracket = "ClosedBracket"; // )
    public const string OpenCurlyBraces = "OpenCurlyBraces"; // {
    public const string ClosedCurlyBraces = "ClosedCurlyBraces"; // }
    public const string QuotationMarks = "QuotationMarks"; // "

    public const string id = "id"; // id
    public const string Print = "print"; // print
    public const string Sin = "sin"; // sin
    public const string Cos = "cos"; // cos
    public const string Log = "log"; // log
    public const string Function = "function";// function
    public const string Let = "let"; // let
    public const string In = "in"; // in
    public const string If = "if"; // if
    public const string Else = "else"; // else

}
