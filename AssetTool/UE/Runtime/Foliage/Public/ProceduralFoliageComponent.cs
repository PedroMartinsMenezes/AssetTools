namespace AssetTool
{
    [JsonAsset("ProceduralFoliageComponent")]
    public class UProceduralFoliageComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}