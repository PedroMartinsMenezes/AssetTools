namespace AssetTool
{
    [JsonAsset("AvaSequenceLibrary")]
    public class UAvaSequenceLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}