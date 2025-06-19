namespace AssetTool
{
    [JsonAsset("BoundsCopyComponent")]
    public class UBoundsCopyComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}