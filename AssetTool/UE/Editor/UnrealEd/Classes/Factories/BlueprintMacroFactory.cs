namespace AssetTool
{
    [JsonAsset("BlueprintMacroFactory")]
    public class UBlueprintMacroFactory : UBlueprintFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}