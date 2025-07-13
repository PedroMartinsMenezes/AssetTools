namespace AssetTool
{
    [JsonAsset("SequencerViewModelStructExtensions")]
    public class USequencerViewModelStructExtensions : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}