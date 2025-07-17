namespace AssetTool
{
    [JsonAsset("CommonUserBasicPresence")]
    public class UCommonUserBasicPresence : UGameInstanceSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}