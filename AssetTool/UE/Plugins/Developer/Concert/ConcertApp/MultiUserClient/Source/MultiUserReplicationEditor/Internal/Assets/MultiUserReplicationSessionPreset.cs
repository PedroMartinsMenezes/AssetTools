namespace AssetTool
{
    [JsonAsset("MultiUserReplicationSessionPreset")]
    public class UMultiUserReplicationSessionPreset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}