namespace AssetTool
{
    [JsonAsset("AvaPlayableLibrary")]
    public class UAvaPlayableLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}