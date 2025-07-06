namespace AssetTool
{
    [JsonAsset("RemoteControlTestObject")]
    public class URemoteControlTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}