namespace AssetTool
{
    [JsonAsset("MassSpawnLocationProcessor")]
    public class UMassSpawnLocationProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}