namespace AssetTool
{
    [JsonAsset("MassEntitySpawnDataGeneratorBase")]
    public class UMassEntitySpawnDataGeneratorBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}