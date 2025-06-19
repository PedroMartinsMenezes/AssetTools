namespace AssetTool
{
    [JsonAsset("AvaTagLibrary")]
    public class UAvaTagLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}