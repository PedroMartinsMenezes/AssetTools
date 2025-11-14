namespace AssetTool
{
    [JsonAsset("RemoteControlLogicConfig")]
    public class URemoteControlLogicConfig : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}