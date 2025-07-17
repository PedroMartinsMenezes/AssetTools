namespace AssetTool
{
    [JsonAsset("LyraExperienceDefinition")]
    public class ULyraExperienceDefinition : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}