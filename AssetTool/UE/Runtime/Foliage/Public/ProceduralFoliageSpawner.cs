namespace AssetTool
{
    [JsonAsset("ProceduralFoliageSpawner")]
    public class UProceduralFoliageSpawner : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}