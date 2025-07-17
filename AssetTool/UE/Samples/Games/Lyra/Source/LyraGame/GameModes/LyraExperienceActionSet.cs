namespace AssetTool
{
    [JsonAsset("LyraExperienceActionSet")]
    public class ULyraExperienceActionSet : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}