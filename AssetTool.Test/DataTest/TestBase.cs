namespace AssetTool.Test
{
    public class TestBase
    {
        static bool initialized = false;

        public TestBase()
        {
            if (!initialized)
            {
                initialized = true;
                Directory.SetCurrentDirectory("..\\..\\..\\..\\");
            }
        }
    }
}