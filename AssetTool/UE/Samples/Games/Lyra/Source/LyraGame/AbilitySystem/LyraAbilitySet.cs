namespace AssetTool
{
    [JsonAsset("LyraAbilitySet")]
    public class ULyraAbilitySet : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}