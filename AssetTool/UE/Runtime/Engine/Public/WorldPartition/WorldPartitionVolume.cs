namespace AssetTool
{
    [JsonAsset("WorldPartitionVolume")]
    public class ADEPRECATED_WorldPartitionVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}