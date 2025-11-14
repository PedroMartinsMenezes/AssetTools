namespace AssetTool
{
    [JsonAsset("CommonUserInfo")]
    public class UCommonUserInfo : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonUserSubsystem")]
    public class UCommonUserSubsystem : UGameInstanceSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}