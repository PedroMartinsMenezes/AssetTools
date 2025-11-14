namespace AssetTool
{
    [JsonAsset("NiagaraStackScriptItemGroup")]
    public class UNiagaraStackScriptItemGroup : UNiagaraStackItemGroup
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}