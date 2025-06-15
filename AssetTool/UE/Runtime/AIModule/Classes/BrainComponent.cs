namespace AssetTool
{
    [JsonAsset("BrainComponent")]
    public class UBrainComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}