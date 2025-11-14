namespace AssetTool
{
    [JsonAsset("ProceduralFoliageComponent")]
    public class UProceduralFoliageComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}