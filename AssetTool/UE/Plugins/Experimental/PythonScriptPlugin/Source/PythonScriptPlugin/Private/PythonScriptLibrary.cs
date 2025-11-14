namespace AssetTool
{
    [JsonAsset("PythonScriptLibrary")]
    public class UPythonScriptLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}