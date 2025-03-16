namespace AssetTool
{
    [JsonAsset("PythonScriptLibrary")]
    public class UPythonScriptLibrary : UBlueprintFunctionLibrary
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}