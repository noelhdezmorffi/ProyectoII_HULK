
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
                __LexicalProcess.Operators["^"] = TokenValues.Exp;
                
                __LexicalProcess.Operators["="] = TokenValues.Assign;
                __LexicalProcess.Operators["=>"] = TokenValues.LambdaExpression;

                __LexicalProcess.Operators[","] = TokenValues.ValueSeparator;
                __LexicalProcess.Operators[";"] = TokenValues.StatementSeparator;
                __LexicalProcess.Operators["("] = TokenValues.OpenBracket;
                __LexicalProcess.Operators[")"] = TokenValues.ClosedBracket;
                __LexicalProcess.Operators["{"] = TokenValues.OpenCurlyBraces;
                __LexicalProcess.Operators["}"] = TokenValues.ClosedCurlyBraces;
                __LexicalProcess.Operators["\""] = TokenValues.QuotationMarks;

                __LexicalProcess.KeyWords["id"]    = TokenValues.id; 
                __LexicalProcess.KeyWords["print"] = TokenValues.Print;  
                __LexicalProcess.KeyWords["sin"]    = TokenValues.Sin; 
                __LexicalProcess.KeyWords["cos"]    = TokenValues.Cos;
                __LexicalProcess.KeyWords["log"]    = TokenValues.Log;                   
                __LexicalProcess.KeyWords["function"]   = TokenValues.Function;     
                __LexicalProcess.KeyWords["let"]   = TokenValues.Let; 
                __LexicalProcess.KeyWords["in"]   = TokenValues.In;
                __LexicalProcess.KeyWords["if"]   = TokenValues.If;
                __LexicalProcess.KeyWords["else"]   = TokenValues.Else;

                __LexicalProcess.Texts["\""] = "\"";
            }

            return __LexicalProcess;
        }
    }
}