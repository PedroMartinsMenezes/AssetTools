namespace AssetTool
{
    [JsonAsset("InstancedActorsManager")]
    public class AInstancedActorsManager : APartitionActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}