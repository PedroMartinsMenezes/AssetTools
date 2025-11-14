namespace AssetTool
{
    [JsonAsset("RemoteControlAPITestObject")]
    public class URemoteControlAPITestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}