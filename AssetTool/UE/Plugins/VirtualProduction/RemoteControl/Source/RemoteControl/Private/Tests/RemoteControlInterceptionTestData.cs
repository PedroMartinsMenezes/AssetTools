namespace AssetTool
{
    [JsonAsset("RemoteControlInterceptionTestObject")]
    public class URemoteControlInterceptionTestObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}