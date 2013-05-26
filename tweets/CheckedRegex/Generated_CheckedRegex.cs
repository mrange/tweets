// ----------------------------------------------------------------------------------------------
// Copyright (c) Mårten Rånge.
// ----------------------------------------------------------------------------------------------
// This source code is subject to terms and conditions of the Microsoft Public License. A 
// copy of the license can be found in the License.html file at the root of this distribution. 
// If you cannot locate the  Microsoft Public License, please send an email to 
// dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
//  by the terms of the Microsoft Public License.
// ----------------------------------------------------------------------------------------------
// You must not remove this notice, or any other, from this software.
// ----------------------------------------------------------------------------------------------





// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart

namespace CheckedRegex
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    
    sealed partial class CheckedRegex_IniVariable
    {
        readonly Match m_match;
        public CheckedRegex_IniVariable (Match match)
        {
            m_match = match;
        }

        public bool GetSuccess ()
        {
            return m_match.Success;
        }

        public Group Group_Variable
        {
            get
            {
                return m_match.Groups[1];
            }
        }

        public string Variable
        {
            get
            {
                var gr = Group_Variable;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Value
        {
            get
            {
                return m_match.Groups[2];
            }
        }

        public string Value
        {
            get
            {
                var gr = Group_Value;
                return gr.Success ? gr.Value : "";
            }
        }


#if DEBUG
        public override string ToString ()
        {
            var sb = new StringBuilder ();

            sb.Append ("IniVariable");

            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Variable");
            sb.Append (" = ");
            sb.Append (Variable);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Value   ");
            sb.Append (" = ");
            sb.Append (Value);

            return sb.ToString ();
        }
#endif

    }

    static partial class CheckedRegex
    {
        public static readonly Regex Regex_IniVariable = new Regex (
            @"^(?<Variable>\S*)\s*\=\s*(?<Value>.*)$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture
            );

        public static CheckedRegex_IniVariable Match_IniVariable (this string s)
        {
            return Match_IniVariable (s, 0, (s ?? "").Length);
        }

        public static CheckedRegex_IniVariable Match_IniVariable (this string s, int startAt)
        {
            return Match_IniVariable (s, startAt, Math.Max ((s ?? "").Length - startAt, 0));
        }

        public static CheckedRegex_IniVariable Match_IniVariable (this string s, int beginning, int length)
        {
            var match = Regex_IniVariable.Match (s ?? "", beginning, length);

            return new CheckedRegex_IniVariable (match);
        }

        public static IEnumerable<CheckedRegex_IniVariable> Matches_IniVariable (this string s)
        {
            return Matches_IniVariable (s, 0);
        }

        public static IEnumerable<CheckedRegex_IniVariable> Matches_IniVariable (this string s, int startAt)
        {
            var matches = Regex_IniVariable.Matches (s ?? "", startAt);

            var count = matches.Count;

            for (var iter = 0; iter < count; ++iter)
            {
                var match = matches[iter];
                yield return new CheckedRegex_IniVariable (match);
            }
        }

        public static bool IsMatch_IniVariable (this string s)
        {
            return IsMatch_IniVariable (s, 0);
        }

        public static bool IsMatch_IniVariable (this string s, int startAt)
        {
            return Regex_IniVariable.IsMatch (s ?? "", startAt);
        }

    }
    
    sealed partial class CheckedRegex_Guid
    {
        readonly Match m_match;
        public CheckedRegex_Guid (Match match)
        {
            m_match = match;
        }

        public bool GetSuccess ()
        {
            return m_match.Success;
        }

        public Group Group_First
        {
            get
            {
                return m_match.Groups[1];
            }
        }

        public string First
        {
            get
            {
                var gr = Group_First;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Second
        {
            get
            {
                return m_match.Groups[2];
            }
        }

        public string Second
        {
            get
            {
                var gr = Group_Second;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Third
        {
            get
            {
                return m_match.Groups[3];
            }
        }

        public string Third
        {
            get
            {
                var gr = Group_Third;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Fourth
        {
            get
            {
                return m_match.Groups[4];
            }
        }

        public string Fourth
        {
            get
            {
                var gr = Group_Fourth;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Fifth
        {
            get
            {
                return m_match.Groups[5];
            }
        }

        public string Fifth
        {
            get
            {
                var gr = Group_Fifth;
                return gr.Success ? gr.Value : "";
            }
        }


#if DEBUG
        public override string ToString ()
        {
            var sb = new StringBuilder ();

            sb.Append ("Guid");

            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("First ");
            sb.Append (" = ");
            sb.Append (First);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Second");
            sb.Append (" = ");
            sb.Append (Second);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Third ");
            sb.Append (" = ");
            sb.Append (Third);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Fourth");
            sb.Append (" = ");
            sb.Append (Fourth);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Fifth ");
            sb.Append (" = ");
            sb.Append (Fifth);

            return sb.ToString ();
        }
#endif

    }

    static partial class CheckedRegex
    {
        public static readonly Regex Regex_Guid = new Regex (
            @"\{(?<First>[0-9|a-f|A-F]{8})\-(?<Second>[0-9|a-f|A-F]{4})\-(?<Third>[0-9|a-f|A-F]{4})\-(?<Fourth>[0-9|a-f|A-F]{4})\-(?<Fifth>[0-9|a-f|A-F]{12})\}",
            RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture
            );

        public static CheckedRegex_Guid Match_Guid (this string s)
        {
            return Match_Guid (s, 0, (s ?? "").Length);
        }

        public static CheckedRegex_Guid Match_Guid (this string s, int startAt)
        {
            return Match_Guid (s, startAt, Math.Max ((s ?? "").Length - startAt, 0));
        }

        public static CheckedRegex_Guid Match_Guid (this string s, int beginning, int length)
        {
            var match = Regex_Guid.Match (s ?? "", beginning, length);

            return new CheckedRegex_Guid (match);
        }

        public static IEnumerable<CheckedRegex_Guid> Matches_Guid (this string s)
        {
            return Matches_Guid (s, 0);
        }

        public static IEnumerable<CheckedRegex_Guid> Matches_Guid (this string s, int startAt)
        {
            var matches = Regex_Guid.Matches (s ?? "", startAt);

            var count = matches.Count;

            for (var iter = 0; iter < count; ++iter)
            {
                var match = matches[iter];
                yield return new CheckedRegex_Guid (match);
            }
        }

        public static bool IsMatch_Guid (this string s)
        {
            return IsMatch_Guid (s, 0);
        }

        public static bool IsMatch_Guid (this string s, int startAt)
        {
            return Regex_Guid.IsMatch (s ?? "", startAt);
        }

    }
    
    sealed partial class CheckedRegex_Date
    {
        readonly Match m_match;
        public CheckedRegex_Date (Match match)
        {
            m_match = match;
        }

        public bool GetSuccess ()
        {
            return m_match.Success;
        }

        public Group Group_Year
        {
            get
            {
                return m_match.Groups[1];
            }
        }

        public string Year
        {
            get
            {
                var gr = Group_Year;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Month
        {
            get
            {
                return m_match.Groups[2];
            }
        }

        public string Month
        {
            get
            {
                var gr = Group_Month;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Day
        {
            get
            {
                return m_match.Groups[3];
            }
        }

        public string Day
        {
            get
            {
                var gr = Group_Day;
                return gr.Success ? gr.Value : "";
            }
        }


#if DEBUG
        public override string ToString ()
        {
            var sb = new StringBuilder ();

            sb.Append ("Date");

            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Year ");
            sb.Append (" = ");
            sb.Append (Year);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Month");
            sb.Append (" = ");
            sb.Append (Month);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Day  ");
            sb.Append (" = ");
            sb.Append (Day);

            return sb.ToString ();
        }
#endif

    }

    static partial class CheckedRegex
    {
        public static readonly Regex Regex_Date = new Regex (
            @"(?<Year>[0-9]{4})\-(?<Month>[0-9]{2})\-(?<Day>[0-9]{2})",
            RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture
            );

        public static CheckedRegex_Date Match_Date (this string s)
        {
            return Match_Date (s, 0, (s ?? "").Length);
        }

        public static CheckedRegex_Date Match_Date (this string s, int startAt)
        {
            return Match_Date (s, startAt, Math.Max ((s ?? "").Length - startAt, 0));
        }

        public static CheckedRegex_Date Match_Date (this string s, int beginning, int length)
        {
            var match = Regex_Date.Match (s ?? "", beginning, length);

            return new CheckedRegex_Date (match);
        }

        public static IEnumerable<CheckedRegex_Date> Matches_Date (this string s)
        {
            return Matches_Date (s, 0);
        }

        public static IEnumerable<CheckedRegex_Date> Matches_Date (this string s, int startAt)
        {
            var matches = Regex_Date.Matches (s ?? "", startAt);

            var count = matches.Count;

            for (var iter = 0; iter < count; ++iter)
            {
                var match = matches[iter];
                yield return new CheckedRegex_Date (match);
            }
        }

        public static bool IsMatch_Date (this string s)
        {
            return IsMatch_Date (s, 0);
        }

        public static bool IsMatch_Date (this string s, int startAt)
        {
            return Regex_Date.IsMatch (s ?? "", startAt);
        }

    }
    
    sealed partial class CheckedRegex_DateTime
    {
        readonly Match m_match;
        public CheckedRegex_DateTime (Match match)
        {
            m_match = match;
        }

        public bool GetSuccess ()
        {
            return m_match.Success;
        }

        public Group Group_Year
        {
            get
            {
                return m_match.Groups[1];
            }
        }

        public string Year
        {
            get
            {
                var gr = Group_Year;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Month
        {
            get
            {
                return m_match.Groups[2];
            }
        }

        public string Month
        {
            get
            {
                var gr = Group_Month;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Day
        {
            get
            {
                return m_match.Groups[3];
            }
        }

        public string Day
        {
            get
            {
                var gr = Group_Day;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Hour
        {
            get
            {
                return m_match.Groups[4];
            }
        }

        public string Hour
        {
            get
            {
                var gr = Group_Hour;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Minute
        {
            get
            {
                return m_match.Groups[5];
            }
        }

        public string Minute
        {
            get
            {
                var gr = Group_Minute;
                return gr.Success ? gr.Value : "";
            }
        }


        public Group Group_Second
        {
            get
            {
                return m_match.Groups[6];
            }
        }

        public string Second
        {
            get
            {
                var gr = Group_Second;
                return gr.Success ? gr.Value : "";
            }
        }


#if DEBUG
        public override string ToString ()
        {
            var sb = new StringBuilder ();

            sb.Append ("DateTime");

            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Year  ");
            sb.Append (" = ");
            sb.Append (Year);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Month ");
            sb.Append (" = ");
            sb.Append (Month);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Day   ");
            sb.Append (" = ");
            sb.Append (Day);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Hour  ");
            sb.Append (" = ");
            sb.Append (Hour);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Minute");
            sb.Append (" = ");
            sb.Append (Minute);
            sb.AppendLine ();
            sb.Append ("  ");
            sb.Append ("Second");
            sb.Append (" = ");
            sb.Append (Second);

            return sb.ToString ();
        }
#endif

    }

    static partial class CheckedRegex
    {
        public static readonly Regex Regex_DateTime = new Regex (
            @"(?<Year>[0-9]{4})\-(?<Month>[0-9]{2})\-(?<Day>[0-9]{2})(T| )(?<Hour>[0-9]{2})\:(?<Minute>[0-9]{2})\:(?<Second>[0-9]{2})",
            RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture
            );

        public static CheckedRegex_DateTime Match_DateTime (this string s)
        {
            return Match_DateTime (s, 0, (s ?? "").Length);
        }

        public static CheckedRegex_DateTime Match_DateTime (this string s, int startAt)
        {
            return Match_DateTime (s, startAt, Math.Max ((s ?? "").Length - startAt, 0));
        }

        public static CheckedRegex_DateTime Match_DateTime (this string s, int beginning, int length)
        {
            var match = Regex_DateTime.Match (s ?? "", beginning, length);

            return new CheckedRegex_DateTime (match);
        }

        public static IEnumerable<CheckedRegex_DateTime> Matches_DateTime (this string s)
        {
            return Matches_DateTime (s, 0);
        }

        public static IEnumerable<CheckedRegex_DateTime> Matches_DateTime (this string s, int startAt)
        {
            var matches = Regex_DateTime.Matches (s ?? "", startAt);

            var count = matches.Count;

            for (var iter = 0; iter < count; ++iter)
            {
                var match = matches[iter];
                yield return new CheckedRegex_DateTime (match);
            }
        }

        public static bool IsMatch_DateTime (this string s)
        {
            return IsMatch_DateTime (s, 0);
        }

        public static bool IsMatch_DateTime (this string s, int startAt)
        {
            return Regex_DateTime.IsMatch (s ?? "", startAt);
        }

    }
}


