namespace AssetTool
{
    [JsonAsset("NiagaraStackScriptItemGroup")]
    public class UNiagaraStackScriptItemGroup : UNiagaraStackItemGroup
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}