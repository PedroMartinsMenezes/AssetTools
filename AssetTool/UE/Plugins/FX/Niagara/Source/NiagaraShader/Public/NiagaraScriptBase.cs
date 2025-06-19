namespace AssetTool
{
    [JsonAsset("NiagaraScriptBase")]
    public class UNiagaraScriptBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}