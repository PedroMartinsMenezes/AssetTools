namespace AssetTool
{
    [JsonAsset("PythonScriptLibrary")]
    public class UPythonScriptLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}