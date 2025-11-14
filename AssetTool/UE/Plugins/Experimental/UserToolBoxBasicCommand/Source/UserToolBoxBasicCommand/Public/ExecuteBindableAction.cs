namespace AssetTool
{
    [JsonAsset("ExecuteBindableAction")]
    public class UExecuteBindableAction : UUTBBaseCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}