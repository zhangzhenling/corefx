// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------


namespace System
{
    public abstract partial class Utf8StringComparer : System.Collections.Generic.IEqualityComparer<Utf8String>
    {
        private Utf8StringComparer() { }
        public static Utf8StringComparer CurrentCulture { get { throw null; } }
        public static Utf8StringComparer CurrentCultureIgnoreCase { get { throw null; } }
        public static Utf8StringComparer InvariantCulture { get { throw null; } }
        public static Utf8StringComparer InvariantCultureIgnoreCase { get { throw null; } }
        public static Utf8StringComparer Ordinal { get { throw null; } }
        public static Utf8StringComparer OrdinalIgnoreCase { get { throw null; } }
        public static Utf8StringComparer Create(System.Globalization.CultureInfo culture, bool ignoreCase) { throw null; }
        public static Utf8StringComparer Create(System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options) { throw null; }
        public abstract bool Equals(Utf8String x, Utf8String y);
        public static Utf8StringComparer FromComparison(StringComparison comparisonType) { throw null; }
        public abstract int GetHashCode(Utf8String obj);
    }
    public abstract partial class StringSegmentComparer : System.Collections.Generic.IComparer<StringSegment>, System.Collections.Generic.IEqualityComparer<StringSegment>
    {
        private StringSegmentComparer() { }
        public static StringSegmentComparer CurrentCulture => throw null;
        public static StringSegmentComparer CurrentCultureIgnoreCase => throw null;
        public static StringSegmentComparer InvariantCulture => throw null;
        public static StringSegmentComparer InvariantCultureIgnoreCase => throw null;
        public static StringSegmentComparer Ordinal => throw null;
        public static StringSegmentComparer OrdinalIgnoreCase => throw null;
        public static StringSegmentComparer Create(System.Globalization.CultureInfo culture, bool ignoreCase) => throw null;
        public static StringSegmentComparer Create(System.Globalization.CultureInfo culture, System.Globalization.CompareOptions options) => throw null;
        public abstract int Compare(StringSegment x, StringSegment y);
        public abstract bool Equals(StringSegment x, StringSegment y);
        public static StringSegmentComparer FromComparison(StringComparison comparisonType) => throw null;
        public abstract int GetHashCode(StringSegment obj);
    }
}