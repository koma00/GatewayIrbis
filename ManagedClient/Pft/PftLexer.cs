//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Pft.g4 by ANTLR 4.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace ManagedClient.Pft {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class PftLexer : Lexer {
	public const int
		UNCONDITIONAL=1, CONDITIONAL=2, REPEATABLE=3, FIELD=4, GLOBALVAR=5, MODESWITCH=6, 
		COMMANDC=7, COMMANDX=8, LAST=9, MFN=10, IF=11, THEN=12, ELSE=13, FI=14, 
		AND=15, OR=16, NOT=17, S=18, L=19, F=20, A=21, P=22, TRIM=23, TRACE=24, 
		ERROR=25, WARNING=26, FATAL=27, DEBUG=28, IOCC=29, NOCC=30, BREAK=31, 
		PLUS=32, MINUS=33, STAR=34, SLASH=35, EQUALS=36, LPAREN=37, RPAREN=38, 
		COMMA=39, SEMICOLON=40, HASH=41, PERCENT=42, COLON=43, TILDA=44, BANG=45, 
		AMPERSAND=46, FUNCNAME=47, UNSIGNED=48, WS=49, COMMENT=50;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] tokenNames = {
		"'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'", 
		"'\\u0006'", "'\\u0007'", "'\b'", "'\t'", "'\n'", "'\\u000B'", "'\f'", 
		"'\r'", "'\\u000E'", "'\\u000F'", "'\\u0010'", "'\\u0011'", "'\\u0012'", 
		"'\\u0013'", "'\\u0014'", "'\\u0015'", "'\\u0016'", "'\\u0017'", "'\\u0018'", 
		"'\\u0019'", "'\\u001A'", "'\\u001B'", "'\\u001C'", "'\\u001D'", "'\\u001E'", 
		"'\\u001F'", "' '", "'!'", "'\"'", "'#'", "'$'", "'%'", "'&'", "'''", 
		"'('", "')'", "'*'", "'+'", "','", "'-'", "'.'", "'/'", "'0'", "'1'", 
		"'2'"
	};
	public static readonly string[] ruleNames = {
		"UNCONDITIONAL", "CONDITIONAL", "REPEATABLE", "FIELD", "GLOBALVAR", "MODESWITCH", 
		"COMMANDC", "COMMANDX", "LAST", "MFN", "IF", "THEN", "ELSE", "FI", "AND", 
		"OR", "NOT", "S", "L", "F", "A", "P", "TRIM", "TRACE", "ERROR", "WARNING", 
		"FATAL", "DEBUG", "IOCC", "NOCC", "BREAK", "PLUS", "MINUS", "STAR", "SLASH", 
		"EQUALS", "LPAREN", "RPAREN", "COMMA", "SEMICOLON", "HASH", "PERCENT", 
		"COLON", "TILDA", "BANG", "AMPERSAND", "FUNCNAME", "DIGIT", "INTEGER", 
		"ALNUM", "UNSIGNED", "WS", "COMMENT"
	};


	public PftLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	public override string GrammarFileName { get { return "Pft.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x34\x173\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x3\x2"+
		"\x3\x2\a\x2p\n\x2\f\x2\xE\x2s\v\x2\x3\x2\x3\x2\x3\x3\x3\x3\a\x3y\n\x3"+
		"\f\x3\xE\x3|\v\x3\x3\x3\x3\x3\x3\x4\x3\x4\a\x4\x82\n\x4\f\x4\xE\x4\x85"+
		"\v\x4\x3\x4\x3\x4\x3\x5\x3\x5\x6\x5\x8B\n\x5\r\x5\xE\x5\x8C\x3\x5\x3\x5"+
		"\x6\x5\x91\n\x5\r\x5\xE\x5\x92\x5\x5\x95\n\x5\x3\x5\x3\x5\x5\x5\x99\n"+
		"\x5\x3\x5\x3\x5\x3\x5\x5\x5\x9E\n\x5\x3\x5\x3\x5\x3\x5\x5\x5\xA3\n\x5"+
		"\x3\x5\x3\x5\x5\x5\xA7\n\x5\x3\x5\x3\x5\x5\x5\xAB\n\x5\x3\x5\x3\x5\x5"+
		"\x5\xAF\n\x5\x3\x6\x3\x6\x6\x6\xB3\n\x6\r\x6\xE\x6\xB4\x3\x6\x3\x6\x5"+
		"\x6\xB9\n\x6\x3\x6\x3\x6\x5\x6\xBD\n\x6\x3\x6\x3\x6\x5\x6\xC1\n\x6\x3"+
		"\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3"+
		"\n\x3\v\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\r\x3\r\x3\r\x3\r\x3\r\x3\xE\x3"+
		"\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3"+
		"\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3"+
		"\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3"+
		"\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3"+
		"\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3"+
		"\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3"+
		"\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 \x3 \x3!\x3!\x3\"\x3\"\x3"+
		"#\x3#\x3$\x3$\x3%\x3%\x3&\x3&\x3\'\x3\'\x3(\x3(\x3)\x3)\x3*\x3*\x3+\x3"+
		"+\x3,\x3,\x3-\x3-\x3.\x3.\x3/\x3/\x3\x30\x3\x30\a\x30\x150\n\x30\f\x30"+
		"\xE\x30\x153\v\x30\x3\x31\x3\x31\x3\x32\x6\x32\x158\n\x32\r\x32\xE\x32"+
		"\x159\x3\x33\x3\x33\x3\x34\x3\x34\x3\x35\x6\x35\x161\n\x35\r\x35\xE\x35"+
		"\x162\x3\x35\x3\x35\x3\x36\x3\x36\x3\x36\x3\x36\a\x36\x16B\n\x36\f\x36"+
		"\xE\x36\x16E\v\x36\x3\x36\x3\x36\x3\x36\x3\x36\x6qz\x83\x16C\x2\x2\x37"+
		"\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13"+
		"\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2"+
		"\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A"+
		"\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2"+
		"\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2-Y\x2."+
		"[\x2/]\x2\x30_\x2\x31\x61\x2\x2\x63\x2\x2\x65\x2\x2g\x2\x32i\x2\x33k\x2"+
		"\x34\x3\x2\x1E\x5\x2\x66\x66ppxx\x3\x2\x32;\x4\x2OOoo\b\x2\x46\x46JJR"+
		"R\x66\x66jjrr\x6\x2NNWWnnww\x4\x2\x45\x45\x65\x65\x4\x2ZZzz\x4\x2HHhh"+
		"\x4\x2PPpp\x4\x2KKkk\x4\x2VVvv\x4\x2JJjj\x4\x2GGgg\x4\x2NNnn\x4\x2UUu"+
		"u\x4\x2\x43\x43\x63\x63\x4\x2\x46\x46\x66\x66\x4\x2QQqq\x4\x2TTtt\x4\x2"+
		"RRrr\x4\x2YYyy\x4\x2IIii\x4\x2\x44\x44\x64\x64\x4\x2WWww\x4\x2MMmm\x4"+
		"\x2\x43\\\x63|\x5\x2\x32;\x43\\\x63|\x5\x2\v\f\xE\xF\"\"\x183\x2\x3\x3"+
		"\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3"+
		"\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13"+
		"\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2"+
		"\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2"+
		"\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2"+
		"+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33"+
		"\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2"+
		"\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2"+
		"\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2"+
		"K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2"+
		"\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x2[\x3\x2\x2\x2"+
		"\x2]\x3\x2\x2\x2\x2_\x3\x2\x2\x2\x2g\x3\x2\x2\x2\x2i\x3\x2\x2\x2\x2k\x3"+
		"\x2\x2\x2\x3m\x3\x2\x2\x2\x5v\x3\x2\x2\x2\a\x7F\x3\x2\x2\x2\t\x88\x3\x2"+
		"\x2\x2\v\xB0\x3\x2\x2\x2\r\xC2\x3\x2\x2\x2\xF\xC6\x3\x2\x2\x2\x11\xC9"+
		"\x3\x2\x2\x2\x13\xCC\x3\x2\x2\x2\x15\xD1\x3\x2\x2\x2\x17\xD5\x3\x2\x2"+
		"\x2\x19\xD8\x3\x2\x2\x2\x1B\xDD\x3\x2\x2\x2\x1D\xE2\x3\x2\x2\x2\x1F\xE5"+
		"\x3\x2\x2\x2!\xE9\x3\x2\x2\x2#\xEC\x3\x2\x2\x2%\xF0\x3\x2\x2\x2\'\xF2"+
		"\x3\x2\x2\x2)\xF4\x3\x2\x2\x2+\xF6\x3\x2\x2\x2-\xF8\x3\x2\x2\x2/\xFA\x3"+
		"\x2\x2\x2\x31\xFF\x3\x2\x2\x2\x33\x105\x3\x2\x2\x2\x35\x10B\x3\x2\x2\x2"+
		"\x37\x113\x3\x2\x2\x2\x39\x119\x3\x2\x2\x2;\x11F\x3\x2\x2\x2=\x124\x3"+
		"\x2\x2\x2?\x129\x3\x2\x2\x2\x41\x12F\x3\x2\x2\x2\x43\x131\x3\x2\x2\x2"+
		"\x45\x133\x3\x2\x2\x2G\x135\x3\x2\x2\x2I\x137\x3\x2\x2\x2K\x139\x3\x2"+
		"\x2\x2M\x13B\x3\x2\x2\x2O\x13D\x3\x2\x2\x2Q\x13F\x3\x2\x2\x2S\x141\x3"+
		"\x2\x2\x2U\x143\x3\x2\x2\x2W\x145\x3\x2\x2\x2Y\x147\x3\x2\x2\x2[\x149"+
		"\x3\x2\x2\x2]\x14B\x3\x2\x2\x2_\x14D\x3\x2\x2\x2\x61\x154\x3\x2\x2\x2"+
		"\x63\x157\x3\x2\x2\x2\x65\x15B\x3\x2\x2\x2g\x15D\x3\x2\x2\x2i\x160\x3"+
		"\x2\x2\x2k\x166\x3\x2\x2\x2mq\a)\x2\x2np\v\x2\x2\x2on\x3\x2\x2\x2ps\x3"+
		"\x2\x2\x2qr\x3\x2\x2\x2qo\x3\x2\x2\x2rt\x3\x2\x2\x2sq\x3\x2\x2\x2tu\a"+
		")\x2\x2u\x4\x3\x2\x2\x2vz\a$\x2\x2wy\v\x2\x2\x2xw\x3\x2\x2\x2y|\x3\x2"+
		"\x2\x2z{\x3\x2\x2\x2zx\x3\x2\x2\x2{}\x3\x2\x2\x2|z\x3\x2\x2\x2}~\a$\x2"+
		"\x2~\x6\x3\x2\x2\x2\x7F\x83\a~\x2\x2\x80\x82\v\x2\x2\x2\x81\x80\x3\x2"+
		"\x2\x2\x82\x85\x3\x2\x2\x2\x83\x84\x3\x2\x2\x2\x83\x81\x3\x2\x2\x2\x84"+
		"\x86\x3\x2\x2\x2\x85\x83\x3\x2\x2\x2\x86\x87\a~\x2\x2\x87\b\x3\x2\x2\x2"+
		"\x88\x8A\t\x2\x2\x2\x89\x8B\x5\x61\x31\x2\x8A\x89\x3\x2\x2\x2\x8B\x8C"+
		"\x3\x2\x2\x2\x8C\x8A\x3\x2\x2\x2\x8C\x8D\x3\x2\x2\x2\x8D\x94\x3\x2\x2"+
		"\x2\x8E\x90\a\x42\x2\x2\x8F\x91\x5\x61\x31\x2\x90\x8F\x3\x2\x2\x2\x91"+
		"\x92\x3\x2\x2\x2\x92\x90\x3\x2\x2\x2\x92\x93\x3\x2\x2\x2\x93\x95\x3\x2"+
		"\x2\x2\x94\x8E\x3\x2\x2\x2\x94\x95\x3\x2\x2\x2\x95\x98\x3\x2\x2\x2\x96"+
		"\x97\a`\x2\x2\x97\x99\x5\x65\x33\x2\x98\x96\x3\x2\x2\x2\x98\x99\x3\x2"+
		"\x2\x2\x99\xA6\x3\x2\x2\x2\x9A\x9D\a]\x2\x2\x9B\x9E\x5\x63\x32\x2\x9C"+
		"\x9E\x5\x13\n\x2\x9D\x9B\x3\x2\x2\x2\x9D\x9C\x3\x2\x2\x2\x9E\xA2\x3\x2"+
		"\x2\x2\x9F\xA0\x5\x43\"\x2\xA0\xA1\x5\x63\x32\x2\xA1\xA3\x3\x2\x2\x2\xA2"+
		"\x9F\x3\x2\x2\x2\xA2\xA3\x3\x2\x2\x2\xA3\xA4\x3\x2\x2\x2\xA4\xA5\a_\x2"+
		"\x2\xA5\xA7\x3\x2\x2\x2\xA6\x9A\x3\x2\x2\x2\xA6\xA7\x3\x2\x2\x2\xA7\xAA"+
		"\x3\x2\x2\x2\xA8\xA9\a,\x2\x2\xA9\xAB\x5\x63\x32\x2\xAA\xA8\x3\x2\x2\x2"+
		"\xAA\xAB\x3\x2\x2\x2\xAB\xAE\x3\x2\x2\x2\xAC\xAD\a\x30\x2\x2\xAD\xAF\x5"+
		"\x63\x32\x2\xAE\xAC\x3\x2\x2\x2\xAE\xAF\x3\x2\x2\x2\xAF\n\x3\x2\x2\x2"+
		"\xB0\xB2\ai\x2\x2\xB1\xB3\t\x3\x2\x2\xB2\xB1\x3\x2\x2\x2\xB3\xB4\x3\x2"+
		"\x2\x2\xB4\xB2\x3\x2\x2\x2\xB4\xB5\x3\x2\x2\x2\xB5\xB8\x3\x2\x2\x2\xB6"+
		"\xB7\a`\x2\x2\xB7\xB9\x5\x65\x33\x2\xB8\xB6\x3\x2\x2\x2\xB8\xB9\x3\x2"+
		"\x2\x2\xB9\xBC\x3\x2\x2\x2\xBA\xBB\a,\x2\x2\xBB\xBD\x5\x63\x32\x2\xBC"+
		"\xBA\x3\x2\x2\x2\xBC\xBD\x3\x2\x2\x2\xBD\xC0\x3\x2\x2\x2\xBE\xBF\a\x30"+
		"\x2\x2\xBF\xC1\x5\x63\x32\x2\xC0\xBE\x3\x2\x2\x2\xC0\xC1\x3\x2\x2\x2\xC1"+
		"\f\x3\x2\x2\x2\xC2\xC3\t\x4\x2\x2\xC3\xC4\t\x5\x2\x2\xC4\xC5\t\x6\x2\x2"+
		"\xC5\xE\x3\x2\x2\x2\xC6\xC7\t\a\x2\x2\xC7\xC8\x5\x63\x32\x2\xC8\x10\x3"+
		"\x2\x2\x2\xC9\xCA\t\b\x2\x2\xCA\xCB\x5\x63\x32\x2\xCB\x12\x3\x2\x2\x2"+
		"\xCC\xCD\aN\x2\x2\xCD\xCE\a\x43\x2\x2\xCE\xCF\aU\x2\x2\xCF\xD0\aV\x2\x2"+
		"\xD0\x14\x3\x2\x2\x2\xD1\xD2\t\x4\x2\x2\xD2\xD3\t\t\x2\x2\xD3\xD4\t\n"+
		"\x2\x2\xD4\x16\x3\x2\x2\x2\xD5\xD6\t\v\x2\x2\xD6\xD7\t\t\x2\x2\xD7\x18"+
		"\x3\x2\x2\x2\xD8\xD9\t\f\x2\x2\xD9\xDA\t\r\x2\x2\xDA\xDB\t\xE\x2\x2\xDB"+
		"\xDC\t\n\x2\x2\xDC\x1A\x3\x2\x2\x2\xDD\xDE\t\xE\x2\x2\xDE\xDF\t\xF\x2"+
		"\x2\xDF\xE0\t\x10\x2\x2\xE0\xE1\t\xE\x2\x2\xE1\x1C\x3\x2\x2\x2\xE2\xE3"+
		"\t\t\x2\x2\xE3\xE4\t\v\x2\x2\xE4\x1E\x3\x2\x2\x2\xE5\xE6\t\x11\x2\x2\xE6"+
		"\xE7\t\n\x2\x2\xE7\xE8\t\x12\x2\x2\xE8 \x3\x2\x2\x2\xE9\xEA\t\x13\x2\x2"+
		"\xEA\xEB\t\x14\x2\x2\xEB\"\x3\x2\x2\x2\xEC\xED\t\n\x2\x2\xED\xEE\t\x13"+
		"\x2\x2\xEE\xEF\t\f\x2\x2\xEF$\x3\x2\x2\x2\xF0\xF1\t\x10\x2\x2\xF1&\x3"+
		"\x2\x2\x2\xF2\xF3\t\xF\x2\x2\xF3(\x3\x2\x2\x2\xF4\xF5\t\t\x2\x2\xF5*\x3"+
		"\x2\x2\x2\xF6\xF7\t\x11\x2\x2\xF7,\x3\x2\x2\x2\xF8\xF9\t\x15\x2\x2\xF9"+
		".\x3\x2\x2\x2\xFA\xFB\t\f\x2\x2\xFB\xFC\t\x14\x2\x2\xFC\xFD\t\v\x2\x2"+
		"\xFD\xFE\t\x4\x2\x2\xFE\x30\x3\x2\x2\x2\xFF\x100\t\f\x2\x2\x100\x101\t"+
		"\x14\x2\x2\x101\x102\t\x11\x2\x2\x102\x103\t\a\x2\x2\x103\x104\t\xE\x2"+
		"\x2\x104\x32\x3\x2\x2\x2\x105\x106\t\xE\x2\x2\x106\x107\t\x14\x2\x2\x107"+
		"\x108\t\x14\x2\x2\x108\x109\t\x13\x2\x2\x109\x10A\t\x14\x2\x2\x10A\x34"+
		"\x3\x2\x2\x2\x10B\x10C\t\x16\x2\x2\x10C\x10D\t\x11\x2\x2\x10D\x10E\t\x14"+
		"\x2\x2\x10E\x10F\t\n\x2\x2\x10F\x110\t\v\x2\x2\x110\x111\t\n\x2\x2\x111"+
		"\x112\t\x17\x2\x2\x112\x36\x3\x2\x2\x2\x113\x114\t\t\x2\x2\x114\x115\t"+
		"\x11\x2\x2\x115\x116\t\f\x2\x2\x116\x117\t\x11\x2\x2\x117\x118\t\xF\x2"+
		"\x2\x118\x38\x3\x2\x2\x2\x119\x11A\t\x12\x2\x2\x11A\x11B\t\xE\x2\x2\x11B"+
		"\x11C\t\x18\x2\x2\x11C\x11D\t\x19\x2\x2\x11D\x11E\t\x17\x2\x2\x11E:\x3"+
		"\x2\x2\x2\x11F\x120\t\v\x2\x2\x120\x121\t\x13\x2\x2\x121\x122\t\a\x2\x2"+
		"\x122\x123\t\a\x2\x2\x123<\x3\x2\x2\x2\x124\x125\t\n\x2\x2\x125\x126\t"+
		"\x13\x2\x2\x126\x127\t\a\x2\x2\x127\x128\t\a\x2\x2\x128>\x3\x2\x2\x2\x129"+
		"\x12A\t\x18\x2\x2\x12A\x12B\t\x14\x2\x2\x12B\x12C\t\xE\x2\x2\x12C\x12D"+
		"\t\x11\x2\x2\x12D\x12E\t\x1A\x2\x2\x12E@\x3\x2\x2\x2\x12F\x130\a-\x2\x2"+
		"\x130\x42\x3\x2\x2\x2\x131\x132\a/\x2\x2\x132\x44\x3\x2\x2\x2\x133\x134"+
		"\a,\x2\x2\x134\x46\x3\x2\x2\x2\x135\x136\a\x31\x2\x2\x136H\x3\x2\x2\x2"+
		"\x137\x138\a?\x2\x2\x138J\x3\x2\x2\x2\x139\x13A\a*\x2\x2\x13AL\x3\x2\x2"+
		"\x2\x13B\x13C\a+\x2\x2\x13CN\x3\x2\x2\x2\x13D\x13E\a.\x2\x2\x13EP\x3\x2"+
		"\x2\x2\x13F\x140\a=\x2\x2\x140R\x3\x2\x2\x2\x141\x142\a&\x2\x2\x142T\x3"+
		"\x2\x2\x2\x143\x144\a\'\x2\x2\x144V\x3\x2\x2\x2\x145\x146\a<\x2\x2\x146"+
		"X\x3\x2\x2\x2\x147\x148\a\x80\x2\x2\x148Z\x3\x2\x2\x2\x149\x14A\a#\x2"+
		"\x2\x14A\\\x3\x2\x2\x2\x14B\x14C\a(\x2\x2\x14C^\x3\x2\x2\x2\x14D\x151"+
		"\t\x1B\x2\x2\x14E\x150\t\x1C\x2\x2\x14F\x14E\x3\x2\x2\x2\x150\x153\x3"+
		"\x2\x2\x2\x151\x14F\x3\x2\x2\x2\x151\x152\x3\x2\x2\x2\x152`\x3\x2\x2\x2"+
		"\x153\x151\x3\x2\x2\x2\x154\x155\t\x3\x2\x2\x155\x62\x3\x2\x2\x2\x156"+
		"\x158\x5\x61\x31\x2\x157\x156\x3\x2\x2\x2\x158\x159\x3\x2\x2\x2\x159\x157"+
		"\x3\x2\x2\x2\x159\x15A\x3\x2\x2\x2\x15A\x64\x3\x2\x2\x2\x15B\x15C\t\x1C"+
		"\x2\x2\x15C\x66\x3\x2\x2\x2\x15D\x15E\x5\x63\x32\x2\x15Eh\x3\x2\x2\x2"+
		"\x15F\x161\t\x1D\x2\x2\x160\x15F\x3\x2\x2\x2\x161\x162\x3\x2\x2\x2\x162"+
		"\x160\x3\x2\x2\x2\x162\x163\x3\x2\x2\x2\x163\x164\x3\x2\x2\x2\x164\x165"+
		"\b\x35\x2\x2\x165j\x3\x2\x2\x2\x166\x167\a\x31\x2\x2\x167\x168\a,\x2\x2"+
		"\x168\x16C\x3\x2\x2\x2\x169\x16B\v\x2\x2\x2\x16A\x169\x3\x2\x2\x2\x16B"+
		"\x16E\x3\x2\x2\x2\x16C\x16D\x3\x2\x2\x2\x16C\x16A\x3\x2\x2\x2\x16D\x16F"+
		"\x3\x2\x2\x2\x16E\x16C\x3\x2\x2\x2\x16F\x170\a\f\x2\x2\x170\x171\x3\x2"+
		"\x2\x2\x171\x172\b\x36\x2\x2\x172l\x3\x2\x2\x2\x17\x2qz\x83\x8C\x92\x94"+
		"\x98\x9D\xA2\xA6\xAA\xAE\xB4\xB8\xBC\xC0\x151\x159\x162\x16C\x3\b\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace ManagedClient.Pft
