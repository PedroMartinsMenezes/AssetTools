namespace AssetTool
{
    [JsonAsset("ReplicationSessionPresetFactory")]
    public class UReplicationSessionPresetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}