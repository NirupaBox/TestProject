using ByBoxDeliverUITests.Drivers;

namespace ByBoxDeliverUITests.Contexts
{
    public class CommonContext
    {
        private AppTestsDriver? _driver { get; set; }

        public AppTestsDriver? Driver
        {
            get => _driver;
            set
            {
                _driver = value;
            }
        }
    }
}
