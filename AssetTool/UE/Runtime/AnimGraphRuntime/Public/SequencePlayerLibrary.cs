namespace AssetTool
{
    [JsonAsset("SequencePlayerLibrary")]
    public class USequencePlayerLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}