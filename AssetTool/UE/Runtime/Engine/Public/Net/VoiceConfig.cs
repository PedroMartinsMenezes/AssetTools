namespace AssetTool
{
    [JsonAsset("VOIPTalker")]
    public class UVOIPTalker : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VOIPStatics")]
    public class UVOIPStatics : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}