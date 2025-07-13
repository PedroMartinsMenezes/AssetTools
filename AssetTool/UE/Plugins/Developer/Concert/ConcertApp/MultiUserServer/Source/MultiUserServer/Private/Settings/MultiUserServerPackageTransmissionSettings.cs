namespace AssetTool
{
    [JsonAsset("MultiUserServerPackageTransmissionSettings")]
    public class UMultiUserServerPackageTransmissionSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}