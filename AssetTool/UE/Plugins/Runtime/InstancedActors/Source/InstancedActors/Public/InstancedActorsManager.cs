namespace AssetTool
{
    [JsonAsset("InstancedActorsManager")]
    public class AInstancedActorsManager : APartitionActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}