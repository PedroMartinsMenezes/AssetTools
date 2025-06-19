namespace AssetTool
{
    [JsonAsset("SkeletalMeshSimplificationSettings")]
    public class USkeletalMeshSimplificationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}