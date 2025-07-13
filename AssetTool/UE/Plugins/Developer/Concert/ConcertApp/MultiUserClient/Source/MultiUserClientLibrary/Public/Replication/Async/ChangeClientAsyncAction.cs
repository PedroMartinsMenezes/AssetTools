namespace AssetTool
{
    [JsonAsset("ChangeClientAsyncAction")]
    public class UChangeClientAsyncAction : UBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}