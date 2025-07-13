namespace AssetTool
{
    [JsonAsset("BuoyancyComponent")]
    public class UBuoyancyComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}