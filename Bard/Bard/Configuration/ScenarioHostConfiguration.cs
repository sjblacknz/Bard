using System;
using Bard.Internal;

namespace Bard.Configuration
{
    public class ScenarioConfiguration
    {
        public static IFluentScenario<TStoryBook> Configure<TStoryBook>(Action<ScenarioOptions<TStoryBook>> configure) where TStoryBook : StoryBook, new()
        {
            var options = new ScenarioOptions<TStoryBook>();

            configure(options);
            
            return new FluentScenario<TStoryBook>(options);
        }
    }
}