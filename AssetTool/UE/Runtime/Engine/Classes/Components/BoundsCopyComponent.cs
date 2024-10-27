namespace AssetTool
{
    [JsonAsset("BoundsCopyComponent")]
    public class UBoundsCopyComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}