namespace AssetTool
{
    [JsonAsset("VPBlueprintLibrary")]
    public class UVPBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}