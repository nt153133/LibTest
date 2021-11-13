using System.Threading.Tasks;
using ff14bot;
using ff14bot.AClasses;
using ff14bot.Behavior;
using TreeSharp;

namespace test
{
    public class Test : BotBase
    {
        private static readonly string botName = "Test";

        private static bool done;

        private Composite _root;

        public override string Name => botName;

        public override bool WantButton => false;

        public override string EnglishName => botName;

        public override PulseFlags PulseFlags => PulseFlags.All;

        public override bool RequiresProfile => false;

        public override Composite Root => _root;

        public override void Start()
        {
            _root = new ActionRunCoroutine(r => testTask());
        }

        private async Task<bool> testTask()
        {
            Lib.Logger.PrintLine("Test");
            TreeRoot.Stop("Stop Requested");
            return false;
        }
    }
}