namespace AssetTool
{
    [JsonAsset("MirrorAnimLibrary")]
    public class UMirrorAnimLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}