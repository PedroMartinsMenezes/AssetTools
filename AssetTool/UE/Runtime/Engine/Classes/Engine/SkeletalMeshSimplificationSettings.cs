namespace AssetTool
{
    [JsonAsset("SkeletalMeshSimplificationSettings")]
    public class USkeletalMeshSimplificationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}