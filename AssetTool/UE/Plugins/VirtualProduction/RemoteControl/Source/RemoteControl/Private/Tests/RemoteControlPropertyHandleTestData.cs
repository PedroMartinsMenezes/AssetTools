namespace AssetTool
{
    [JsonAsset("RemoteControlAPITestObject")]
    public class URemoteControlAPITestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}