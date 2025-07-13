namespace AssetTool
{
    [JsonAsset("SequencerToolsFunctionLibrary")]
    public class USequencerToolsFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}