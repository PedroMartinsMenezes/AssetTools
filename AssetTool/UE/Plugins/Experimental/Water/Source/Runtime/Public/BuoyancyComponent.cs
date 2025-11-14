namespace AssetTool
{
    [JsonAsset("BuoyancyComponent")]
    public class UBuoyancyComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}