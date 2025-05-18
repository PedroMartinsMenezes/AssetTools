namespace AssetTool
{
    [JsonAsset("MoviePipelineSetting_BlueprintBase")]
    public class UMoviePipelineSetting_BlueprintBase : UMoviePipelineSetting
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}