namespace AssetTool
{
    [JsonAsset("RemoteControlLogicConfig")]
    public class URemoteControlLogicConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}