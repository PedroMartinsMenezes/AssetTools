namespace AssetTool
{
    [JsonAsset("NiagaraStackModuleItem")]
    public class UNiagaraStackModuleItem : UNiagaraStackItem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}