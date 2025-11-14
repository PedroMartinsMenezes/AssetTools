namespace AssetTool
{
    [JsonAsset("MoviePipelineCameraSetting")]
    public class UMoviePipelineCameraSetting : UMoviePipelineSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}