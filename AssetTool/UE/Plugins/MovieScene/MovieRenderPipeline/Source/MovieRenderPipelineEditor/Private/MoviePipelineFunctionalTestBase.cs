namespace AssetTool
{
    [JsonAsset("MoviePipelineFunctionalTestBase")]
    public class AMoviePipelineFunctionalTestBase : AFunctionalTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}