namespace AssetTool
{
    [JsonAsset("SequenceEvaluatorLibrary")]
    public class USequenceEvaluatorLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}