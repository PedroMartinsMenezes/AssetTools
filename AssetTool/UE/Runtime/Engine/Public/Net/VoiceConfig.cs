namespace AssetTool
{
    [JsonAsset("VOIPTalker")]
    public class UVOIPTalker : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VOIPStatics")]
    public class UVOIPStatics : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}