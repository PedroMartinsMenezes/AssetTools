namespace AssetTool
{
    [JsonAsset("ExecuteBindableAction")]
    public class UExecuteBindableAction : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}