﻿using JetBrains.ReSharper.FeaturesTestFramework.Intentions;
using JetBrains.ReSharper.Plugins.Unity.Feature.Services.QuickFixes;
using NUnit.Framework;

namespace JetBrains.ReSharper.Plugins.Unity.Tests.Intentions.QuickFixes
{
    [TestUnity]
    public class ConvertToScriptableObjectCreateInstanceQuickFixAvailabilityTests
        : QuickFixAvailabilityTestBase
    {
        protected override string RelativeTestDataPath => @"Intentions\QuickFixes\ConvertToScriptableObjectCreateInstance\Availability";

        [Test] public void Test01() { DoNamedTest(); }
        [Test] public void Test02() { DoNamedTest("MyScriptableObject.cs"); }
    }

    [TestUnity]
    public class ConvertToScriptableObjectCreateInstanceQuickFixTests
        : QuickFixTestBase<ConvertToScriptableObjectCreateInstanceQuickFix>
    {
        protected override string RelativeTestDataPath => @"Intentions\QuickFixes\ConvertToScriptableObjectCreateInstance";
        protected override bool AllowHighlightingOverlap => true;

        [Test] public void Test01() { DoNamedTest(); }
        [Test] public void Test02() { DoNamedTest("MyScriptableObject.cs"); }
    }
}