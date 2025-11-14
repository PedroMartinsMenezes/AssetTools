namespace AssetTool
{
    [JsonAsset("VPBlueprintLibrary")]
    public class UVPBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}