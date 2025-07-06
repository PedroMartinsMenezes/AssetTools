namespace AssetTool
{
    [JsonAsset("RemoteControlInterceptionTestObject")]
    public class URemoteControlInterceptionTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}