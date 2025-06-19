namespace AssetTool
{
    [JsonAsset("ConstraintsScriptingLibrary")]
    public class UConstraintsScriptingLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}