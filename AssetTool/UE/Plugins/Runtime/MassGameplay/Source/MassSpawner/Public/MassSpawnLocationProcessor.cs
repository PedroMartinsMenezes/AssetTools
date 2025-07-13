namespace AssetTool
{
    [JsonAsset("MassSpawnLocationProcessor")]
    public class UMassSpawnLocationProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}