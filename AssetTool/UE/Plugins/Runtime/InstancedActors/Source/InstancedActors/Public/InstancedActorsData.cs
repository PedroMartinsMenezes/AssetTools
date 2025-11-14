namespace AssetTool
{
    [JsonAsset("InstancedActorsData")]
    public class UInstancedActorsData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}