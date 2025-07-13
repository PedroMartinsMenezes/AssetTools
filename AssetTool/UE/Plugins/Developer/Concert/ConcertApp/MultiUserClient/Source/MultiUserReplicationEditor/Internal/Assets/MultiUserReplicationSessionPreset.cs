namespace AssetTool
{
    [JsonAsset("MultiUserReplicationSessionPreset")]
    public class UMultiUserReplicationSessionPreset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}