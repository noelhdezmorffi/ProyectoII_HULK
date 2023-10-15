
public static class Lexer
{
    private static LexicalAnalyzer? __LexicalProcess;
    public static LexicalAnalyzer LexicalAnalyzer
    {
        get
        {
            if (__LexicalProcess == null)
            {
                __LexicalProcess = new LexicalAnalyzer();

                __LexicalProcess.Operators["+"] = TokenValues.Add;
                __LexicalProcess.Operators["*"] = TokenValues.Mul;
                __LexicalProcess.Operators["-"] = TokenValues.Sub;
                __LexicalProcess.Operators["/"] = TokenValues.Div;
                __LexicalProcess.Operators["="] = TokenValues.Assign;

                __LexicalProcess.Operators[","] = TokenValues.ValueSeparator;
                __LexicalProcess.Operators[";"] = TokenValues.StatementSeparator;
                __LexicalProcess.Operators["("] = TokenValues.OpenBracket;
                __LexicalProcess.Operators[")"] = TokenValues.ClosedBracket;
                __LexicalProcess.Operators["{"] = TokenValues.OpenCurlyBraces;
                __LexicalProcess.Operators["}"] = TokenValues.ClosedCurlyBraces;

                __LexicalProcess.KeyWords["id"]    = TokenValues.id; 
                __LexicalProcess.KeyWords["let"]   = TokenValues.let;           

                __LexicalProcess.Texts["\""] = "\"";
            }

            return __LexicalProcess;
        }
    }
}