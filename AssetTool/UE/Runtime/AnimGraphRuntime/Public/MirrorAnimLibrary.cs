namespace AssetTool
{
    [JsonAsset("MirrorAnimLibrary")]
    public class UMirrorAnimLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}