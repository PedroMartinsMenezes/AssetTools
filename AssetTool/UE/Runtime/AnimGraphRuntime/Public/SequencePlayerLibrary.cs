namespace AssetTool
{
    [JsonAsset("SequencePlayerLibrary")]
    public class USequencePlayerLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}