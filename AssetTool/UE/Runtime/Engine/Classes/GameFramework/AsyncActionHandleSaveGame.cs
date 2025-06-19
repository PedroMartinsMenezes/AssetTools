namespace AssetTool
{
    [JsonAsset("AsyncActionHandleSaveGame")]
    public class UAsyncActionHandleSaveGame : UBlueprintAsyncActionBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}