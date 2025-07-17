namespace AssetTool
{
    [JsonAsset("LyraUserFacingExperienceDefinition")]
    public class ULyraUserFacingExperienceDefinition : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}