namespace AssetTool
{
    [JsonAsset("MultiUserServerPackageTransmissionSettings")]
    public class UMultiUserServerPackageTransmissionSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}