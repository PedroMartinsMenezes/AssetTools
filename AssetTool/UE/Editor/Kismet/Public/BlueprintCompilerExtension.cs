namespace AssetTool
{
    [JsonAsset("BlueprintCompilerExtension")]
    public class UBlueprintCompilerExtension : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}