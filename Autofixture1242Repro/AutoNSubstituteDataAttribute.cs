using AutoFixture;
using AutoFixture.AutoNSubstitute;
using AutoFixture.NUnit3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autofixture1242Repro
{
    public class AutoNSubstituteDataAttribute : AutoDataAttribute
    {
        public AutoNSubstituteDataAttribute()
            : base(() => new Fixture().Customize(new AutoNSubstituteCustomization()))
        {

        }
    }
}
