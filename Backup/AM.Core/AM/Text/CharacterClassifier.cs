/* CharacterClassifier.cs -- character classifier
   Ars Magna project, https://www.assembla.com/spaces/arsmagna */

#region Using directives

using System;
using System.Collections.Generic;

#endregion

namespace AM.Text
{
    /// <summary>
    /// Character classifier.
    /// </summary>
    [Serializable]
    public sealed class CharacterClassifier
        : Dictionary < char, CharacterClass >
    {
        #region Public methods

        /// <summary>
        /// Classify character.
        /// </summary>
        /// <param name="characterClass"></param>
        /// <param name="character"></param>
        public void Add
            (
            CharacterClass characterClass,
            char character )
        {
            CharacterClass cc;
            if ( TryGetValue
                (
                 character,
                 out cc ) )
            {
                this [ character ] = cc | characterClass;
            }
            else
            {
                this [ character ] = characterClass;
            }
        }

        /// <summary>
        /// Classify characters.
        /// </summary>
        /// <param name="characterClass"></param>
        /// <param name="characters"></param>
        public void Add
            (
            CharacterClass characterClass,
            params char[] characters )
        {
            foreach ( char ch in characters )
            {
                Add
                    (
                     characterClass,
                     ch );
            }
        }

        /// <summary>
        /// Add character range.
        /// </summary>
        /// <param name="characterClass"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void AddRange
            (
            CharacterClass characterClass,
            char from,
            char to )
        {
            for ( char ch = from; ch <= to; ch++ )
            {
                Add
                    (
                     characterClass,
                     ch );
            }
        }

        /// <summary>
        /// Remove character.
        /// </summary>
        /// <param name="characterClass"></param>
        /// <param name="character"></param>
        public void Remove
            (
            CharacterClass characterClass,
            char character )
        {
            CharacterClass cc;
            if ( TryGetValue
                (
                 character,
                 out cc ) )
            {
                if ( cc == characterClass )
                {
                    Remove ( character );
                }
                else
                {
                    this [ character ] = cc & ~characterClass;
                }
            }
        }

        /// <summary>
        /// Remove characters.
        /// </summary>
        /// <param name="characterClass"></param>
        /// <param name="characters"></param>
        public void Remove
            (
            CharacterClass characterClass,
            params char[] characters )
        {
            foreach ( char ch in characters )
            {
                Remove
                    (
                     characterClass,
                     ch );
            }
        }

        /// <summary>
        /// Remove character range.
        /// </summary>
        /// <param name="characterClass"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void RemoveRange
            (
            CharacterClass characterClass,
            char from,
            char to )
        {
            for ( char ch = from; ch <= to; ch++ )
            {
                Remove
                    (
                     characterClass,
                     ch );
            }
        }

        /// <summary>
        /// Default character classifier.
        /// </summary>
        public static CharacterClassifier Default
        {
            get
            {
                CharacterClassifier result = new CharacterClassifier ();

                result.Add
                    (
                     CharacterClass.Whitespace,
                     ' ',
                     '\n',
                     '\r',
                     '\t',
                     '\v' );
                result.Add
                    (
                     CharacterClass.Quote,
                     '\'',
                     '"' );
                result.Add
                    (
                     CharacterClass.Punctuation,
                     '.',
                     ',',
                     ':',
                     ';',
                     '!',
                     '?',
                     '(',
                     ')',
                     '[',
                     ']',
                     '{',
                     '}',
                     '+',
                     '-',
                     '*',
                     '/',
                     '\\',
                     '^',
                     '<',
                     '>',
                     '=',
                     '|',
                     '&' );
                result.AddRange
                    (
                     CharacterClass.Digit,
                     '0',
                     '9' );
                result.AddRange
                    (
                     CharacterClass.Word,
                     'a',
                     'z' );
                result.AddRange
                    (
                     CharacterClass.Word,
                     'A',
                     'Z' );
                result.Add
                    (
                     CharacterClass.Word,
                     '_' );

                return result;
            }
        }

        #endregion
    }
}
