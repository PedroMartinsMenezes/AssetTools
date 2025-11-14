namespace AssetTool
{
    [JsonAsset("RemoteControlTestObject")]
    public class URemoteControlTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}