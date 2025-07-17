namespace AssetTool
{
    [JsonAsset("CommonUserInfo")]
    public class UCommonUserInfo : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonUserSubsystem")]
    public class UCommonUserSubsystem : UGameInstanceSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}