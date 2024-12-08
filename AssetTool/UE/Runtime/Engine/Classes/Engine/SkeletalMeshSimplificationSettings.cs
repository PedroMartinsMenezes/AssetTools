namespace AssetTool
{
    [JsonAsset("SkeletalMeshSimplificationSettings")]
    public class USkeletalMeshSimplificationSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}