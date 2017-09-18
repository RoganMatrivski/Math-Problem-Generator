/*
 * @(#)ParserSymbol.cs        3.0.0    2016-05-07
 *
 * You may use this software under the condition of "Simplified BSD License"
 *
 * Copyright 2010-2016 MARIUSZ GROMADA. All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without modification, are
 * permitted provided that the following conditions are met:
 *
 *    1. Redistributions of source code must retain the above copyright notice, this list of
 *       conditions and the following disclaimer.
 *
 *    2. Redistributions in binary form must reproduce the above copyright notice, this list
 *       of conditions and the following disclaimer in the documentation and/or other materials
 *       provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY <MARIUSZ GROMADA> ``AS IS'' AND ANY EXPRESS OR IMPLIED
 * WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
 * FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> OR
 * CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON
 * ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
 * NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF
 * ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 *
 * The views and conclusions contained in the software and documentation are those of the
 * authors and should not be interpreted as representing official policies, either expressed
 * or implied, of MARIUSZ GROMADA.
 *
 * If you have any questions/bugs feel free to contact:
 *
 *     Mariusz Gromada
 *     mariuszgromada.org@gmail.com
 *     http://mathparser.org
 *     http://mathspace.pl
 *     http://janetsudoku.mariuszgromada.org
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *     http://mariuszgromada.github.io/MathParser.org-mXparser
 *     http://mxparser.sourceforge.net
 *     http://bitbucket.org/mariuszgromada/mxparser
 *     http://mxparser.codeplex.com
 *     http://github.com/mariuszgromada/Janet-Sudoku
 *     http://janetsudoku.codeplex.com
 *     http://sourceforge.net/projects/janetsudoku
 *     http://bitbucket.org/mariuszgromada/janet-sudoku
 *     http://github.com/mariuszgromada/MathParser.org-mXparser
 *
 *                              Asked if he believes in one God, a mathematician answered:
 *                              "Yes, up to isomorphism."
 */
using System;

namespace org.mariuszgromada.math.mxparser.parsertokens {
	/**
	 * Parser symbols - mXparser tokens definition.
	 *
	 * @author         <b>Mariusz Gromada</b><br>
	 *                 <a href="mailto:mariuszgromada.org@gmail.com">mariuszgromada.org@gmail.com</a><br>
	 *                 <a href="http://mathspace.pl" target="_blank">MathSpace.pl</a><br>
	 *                 <a href="http://mathparser.org" target="_blank">MathParser.org - mXparser project page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/MathParser.org-mXparser" target="_blank">mXparser on GitHub</a><br>
	 *                 <a href="http://mxparser.sourceforge.net" target="_blank">mXparser on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/mxparser" target="_blank">mXparser on Bitbucket</a><br>
	 *                 <a href="http://mxparser.codeplex.com" target="_blank">mXparser on CodePlex</a><br>
	 *                 <a href="http://janetsudoku.mariuszgromada.org" target="_blank">Janet Sudoku - project web page</a><br>
	 *                 <a href="http://github.com/mariuszgromada/Janet-Sudoku" target="_blank">Janet Sudoku on GitHub</a><br>
	 *                 <a href="http://janetsudoku.codeplex.com" target="_blank">Janet Sudoku on CodePlex</a><br>
	 *                 <a href="http://sourceforge.net/projects/janetsudoku" target="_blank">Janet Sudoku on SourceForge</a><br>
	 *                 <a href="http://bitbucket.org/mariuszgromada/janet-sudoku" target="_blank">Janet Sudoku on BitBucket</a><br>
	 *
	 * @version        3.0.0
	 */
	[CLSCompliant(true)]
	public sealed class ParserSymbol {
		/**
		* ParserSymbol - reg exp patterns.
		*/
		public const String Digits = "([0-9]+)";
		public const String HexDigits = "(([0-9]|[A-F])+)";
		public const String Exp = "[eE][+-]?" + Digits;
		public const String fpRegex =
				("[\\x00-\\x20]*" +  // Optional leading "whitespace"
				"[+-]?(" + // Optional sign character
				"NaN|" +           // "NaN" string
				"Infinity|" +      // "Infinity" string
				"(((" + Digits + "(\\.)?(" + Digits + "?)(" + Exp + ")?)|" +
				"(\\.(" + Digits + ")(" + Exp + ")?)|" +
				"((" +
				// 0[xX] HexDigits ._opt BinaryExponent FloatTypeSuffix_opt
				"(0[xX]" + HexDigits + "(\\.)?)|" +
				// 0[xX] HexDigits_opt . HexDigits BinaryExponent FloatTypeSuffix_opt
				"(0[xX]" + HexDigits + "?(\\.)" + HexDigits + ")" +
				")[pP][+-]?" + Digits + "))" +
				"[fFdD]?))" +
				"[\\x00-\\x20]*");
		public const String NOT_NUM = "[^0-9.-]";
		public const String TWO_DOT = "[0-9]*[.][0-9]*[.][0-9]*";
		public const String TWO_MIN = "[0-9]*[-][0-9]*[-][0-9]*";
		public const String REAL = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
		public const String INTEGER = "^([-])[0-9]+$";
		public const String NUMBER = fpRegex;
		public const String nameOnlyTokenRegExp = "([a-zA-Z_])+([a-zA-Z0-9_])*";
		public const String nameTokenRegExp = "(\\s)*" + nameOnlyTokenRegExp + "(\\s)*";
		public const String paramsTokenRegeExp = "(\\s)*\\(" + "(" + nameTokenRegExp + ",(\\s)*)*" + nameTokenRegExp + "\\)(\\s)*";
		public const String constArgDefStrRegExp = nameTokenRegExp + "=" + "(\\s)*(.)+(\\s)*";
		public const String functionDefStrRegExp = nameTokenRegExp + paramsTokenRegeExp + "=" + "(\\s)*(.)+(\\s)*";
		public const String function1ArgDefStrRegExp = nameTokenRegExp + "(\\s)*\\(" + nameTokenRegExp + "(\\s)*\\)(\\s)*" + "=" + "(\\s)*(.)+(\\s)*";

		/**
		 * ParserSymbol - token type id.
		 */
		public const int TYPE_ID							= 20;
		public const String TYPE_DESC						= "Parser Symbol";
		/**
		 * ParserSymbol - tokens id.
		 */
		public const int LEFT_PARENTHESES_ID				= 1;
		public const int RIGHT_PARENTHESES_ID				= 2;
		public const int COMMA_ID							= 3;
		public const int NUMBER_ID							= 1;
		public const int NUMBER_TYPE_ID						= 0;
		/**
		 * ParserSymbol - tokens key words.
		 */
		public const String LEFT_PARENTHESES_STR 			= "(";
		public const String RIGHT_PARENTHESES_STR			= ")";
		public const String COMMA_STR						= ",";
		public const String SEMI_STR						= ";";
		public const String NUMBER_STR						= "_num_";
		public const String NUMBER_REG_EXP					= fpRegex;

		/**
		 * ParserSymbol - tokens description.
		 */
		public const String LEFT_PARENTHESES_DESC 			= "left parentheses";
		public const String RIGHT_PARENTHESES_DESC			= "right parentheses";
		public const String COMMA_DESC						= "comma (function parameters)";
		public const String SEMI_DESC						= "semicolon (function parameters)";
		public const String NUMBER_DESC						= "decimal number";
		public const String NUMBER_REG_DESC					= "regullar expression for decimal numbers";
	}
}