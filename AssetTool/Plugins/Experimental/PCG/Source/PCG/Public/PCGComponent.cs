namespace AssetTool
{
    [JsonAsset("PCGComponent")]
    public class UPCGComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}