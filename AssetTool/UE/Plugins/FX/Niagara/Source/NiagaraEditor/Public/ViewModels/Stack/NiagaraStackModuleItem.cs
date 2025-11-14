namespace AssetTool
{
    [JsonAsset("NiagaraStackModuleItem")]
    public class UNiagaraStackModuleItem : UNiagaraStackItem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}