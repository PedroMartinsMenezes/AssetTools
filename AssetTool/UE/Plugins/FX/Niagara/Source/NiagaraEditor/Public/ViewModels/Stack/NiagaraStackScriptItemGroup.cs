namespace AssetTool
{
    [JsonAsset("NiagaraStackScriptItemGroup")]
    public class UNiagaraStackScriptItemGroup : UNiagaraStackItemGroup
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}