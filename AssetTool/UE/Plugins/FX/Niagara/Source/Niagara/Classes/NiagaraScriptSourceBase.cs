namespace AssetTool
{
    [JsonAsset("NiagaraScriptSourceBase")]
    public class UNiagaraScriptSourceBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}