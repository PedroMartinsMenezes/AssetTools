namespace AssetTool
{
    [JsonAsset("AvaPlayableLibrary")]
    public class UAvaPlayableLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}