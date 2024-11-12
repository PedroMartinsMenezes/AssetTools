namespace AssetTool
{
    [JsonAsset("NiagaraScriptBase")]
    public class UNiagaraScriptBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
