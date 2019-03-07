﻿using System;
using Xunit;
using Xunit.Sdk;

namespace Hangfire.Core.Tests
{
    [XunitTestCaseDiscoverer("Hangfire.Core.Tests.DataCompatibilityRangeTheoryDiscoverer", "Hangfire.Core.Tests")]
    [AttributeUsage(AttributeTargets.Method)]
    internal class DataCompatibilityRangeTheoryAttribute : TheoryAttribute
    {
        public DataCompatibilityRangeTheoryAttribute()
        {
            MinLevel = DataCompatibilityRangeFactAttribute.PossibleMinLevel;
            MaxExclusiveLevel = DataCompatibilityRangeFactAttribute.PossibleMaxExcludingLevel;
        }

        public CompatibilityLevel MinLevel { get; set; }
        public CompatibilityLevel MaxExclusiveLevel { get; set; }
    }
}